from __future__ import print_function
import logging
import time
import requests
import grpc
import person_pb2
import person_pb2_grpc
import multiprocessing

request_session = None
grpc_session = None

grpc_host = 'localhost:26307'
rest_host = 'http://localhost:26353/person/'

def set_global_session_rest():
    global session
    if not session:
        session = requests.Session()

def set_global_session_grpc():
    global grpc_session
    if not grpc_session:
        channel = grpc.insecure_channel('localhost:26307')
        grpc_session = person_pb2_grpc.PersonServStub(channel)

def run():
    print("Running non-db calls:")
    rungrpc()
    runrest()
    print("Running db calls:")
    rungrpcdb()
    runrestdb()   
    print("Multi-core processing:")
    runconcurrentgrpcdb()

def rungrpc():
    start_time = time.time()
    channel = grpc.insecure_channel(grpc_host)
    stub = person_pb2_grpc.PersonServStub(channel)
    for x in range(1,4000):
        response = stub.GetPerson(person_pb2.GetPersonRequest(id= x))
        #print("Person client received "  + str(response.id) + " " + response.name + " " + response.email)

    print("GRPC Exection time: ---%s seconds ---" % (time.time() - start_time))

def runrest():
    start_time = time.time()
    for x in range(1,4000):
        resp = requests.get(rest_host + str(x))
        #print("Rest Response: " + resp.text)

    print("REST Exection time: ---%s seconds ---" % (time.time() - start_time))

def runrestdb():
    start_time = time.time()
    for x in range(1,400):
        resp = requests.get(rest_host + 'db/' + str(x))
        #print("Rest Response: " + resp.text)

    print("REST DB Exection time: ---%s seconds ---" % (time.time() - start_time))

def rungrpcdb():
    start_time = time.time()
    channel = grpc.insecure_channel(grpc_host)
    stub = person_pb2_grpc.PersonServStub(channel)
    for x in range(1,400):
        response = stub.GetDbPerson(person_pb2.GetPersonRequest(id=x))
        #print("Person client received "  + str(response.id) + " " + response.name + " " + response.email)
    
    print("GRPC DB Exection time: ---%s seconds ---" % (time.time() - start_time))

def runconcurrentgrpcdb():
    start_time = time.time()
    num_range = range(1,400)
    with multiprocessing.Pool(initializer=set_global_session_grpc) as pool:
        pool.map(execute_grpc_request, num_range)
    print("GRPC Multiprocessing DB Exection time: ---%s seconds ---" % (time.time() - start_time))

def execute_grpc_request(person_id):
    grpc_session.GetDbPerson(person_pb2.GetPersonRequest(id=person_id))


#def runconcurrentrestdb():
#    start_time = time.time()

if __name__ == '__main__':
    logging.basicConfig()
    run()

###
# Stats example:
# 500 records
# -----------
# GRPC Exec time
# GRPC Exection time: ---4.778871536254883 seconds ---
# REST EXEC time
# REST Exection time: ---7.932521820068359 seconds ---
# -----------
# 4000 records
# NON DB:
# GRPC Exection time: ---40.365668535232544 seconds ---
# REST Exection time: ---132.4881947040558 seconds ---
# DB:
# GRPC DB Exection time: ---236.62367725372314 seconds ---
# REST DB Exection time: ---337.36364364624023 seconds ---
# ----------
# 400 records
# DB:
# GRPC DB Exection time: ---35.77449584007263 seconds ---
# REST DB Exection time: ---79.86235094070435 seconds ---
# Multi-core/DB:
# GRPC Multiprocessing DB Exection time: ---16.054117679595947 seconds ---    
###
  