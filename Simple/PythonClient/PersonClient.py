from __future__ import print_function
import logging
import time
import requests
import grpc
import person_pb2
import person_pb2_grpc
import multiprocessing
import sys

def run_grpc(grpc_host, grpc_loops, print_results):
    channel = grpc.insecure_channel(grpc_host)
    stub = person_pb2_grpc.PersonServStub(channel)
    for x in range(1,int(grpc_loops)):
        grpc_response = stub.GetPerson(person_pb2.GetPersonRequest(id = x))
        if print_results:
            print("Person client received " + str(grpc_response.id) + " " + grpc_response.name + " " + grpc_response.email)

def run():
    print("Number of args: " + str(len(sys.argv)))
    if(len(sys.argv) == 4):
        grpc_host = sys.argv[1]
        grpc_loops = sys.argv[2]
        print_results = sys.argv[3]
    else:
        print("Invalid number of parameters.")
        print("Parameters: HOST NUM_OF_LOOPS VERBOSE_LOGGING")

    print("Running Test gRPC Calls")
    run_grpc(grpc_host,grpc_loops,print_results)

if __name__ == '__main__':
    logging.basicConfig()
    run()