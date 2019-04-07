import numpy as np
import tensorflow as tf
from keras.models import load_model
import pandas as pd
#I don't think the following modules are needed to run this script:
#from tensorflow import keras
#from keras import layers
#from keras.models import Sequential
#from keras.layers import Dense
#from tensorflow.keras import layers
#import h5py

def graduate_algorithm(GRE,TOEFL,SOP,LOR,CGPA,research,school_info):
	rankings = []
	output = []
	percentAdmin = []

	#load generated model- must be in same folder
	model = load_model('admission_model.h5',custom_objects={"GlorotUniform": tf.keras.initializers.glorot_uniform})

	#find number of schools in input
	schools = len(school_info)

	#create array of all possible rankings from 1-5
	for i in range(schools):
		rankings.append(1+((4*(school_info[i][1]))/1000))
		
	#input = [GRE,TOEFL,rankings,SOP,LOR,CGPA,research]
	#this array is used as input to the algorithm
	#to-do: place imported values into array
	input = [[GRE]*schools,[TOEFL]*schools,rankings,[SOP]*schools,[LOR]*schools,[CGPA]*schools,[research]*schools]

	#generate admission chances
	admission_chances = model.predict(np.transpose(input))
	admission_chances = admission_chances.flatten()

	#generate output array
	for i in range(schools):
		output.append([school_info[i][0],admission_chances[i]])
		
	
	#take top 20
	for x in range(20):
		for y in range(2)
		percentAdmin[x][y] = output[x][y]
	return percentAdmin