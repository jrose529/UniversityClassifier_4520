import numpy as np
import tensorflow as tf
from keras.models import load_model
import pandas as pd
import sys



#CHANGE THIS
#path to model
file_path = "C:\\Users\\stock\\Desktop\\Classes\\SWE\\Project\\admission_model.h5"


schools = 0
school_names = []
rankings = []
output_string = ""

#get scores from input
GRE = sys.argv[1]
TOEFL = sys.argv[2]
SOP = sys.argv[3]
LOR = sys.argv[4]
CGPA = sys.argv[5]
research = sys.argv[6]


school_info = ""

#get school/ranking list from input
for index in range(len(sys.argv)):
	if index > 6:
		school_info = school_info + sys.argv[index]
		
#get data by splitting commas
school_info = school_info.split(",")

for i,index in enumerate(school_info):
	if len(index) > 0:
		if (i % 2) == 0:
			school_names.append(index)
		else:
			schools = schools + 1
			rankings.append(index)
			
#scale rankings between 1 and 5
for rank in range(len(rankings)):
	rankings[rank] = (1+((4*(int(rankings[rank])))/1000))
		
#load generated model- must be in same folder
model = load_model(file_path,custom_objects={"GlorotUniform": tf.keras.initializers.glorot_uniform})
	
#input = [GRE,TOEFL,rankings,SOP,LOR,CGPA,research]
#this array is used as input to the algorithm
#to-do: place imported values into array
input = np.array([[GRE]*schools,[TOEFL]*schools,rankings,[SOP]*schools,[LOR]*schools,[CGPA]*schools,[research]*schools])

#generate admission chances
admission_chances = model.predict(np.transpose(input))

admission_chances = admission_chances.flatten()

output_string = "Results:"

#generate output array
for i in range(schools):
	output_string = output_string + school_names[i] + ","
	output_string = output_string + str(admission_chances[i]) + ","

print(output_string)