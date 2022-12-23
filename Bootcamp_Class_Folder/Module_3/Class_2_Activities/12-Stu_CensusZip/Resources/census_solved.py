import os

import csv

census_csv = os.path.join('..','Resources', 'census_solved.py')

with open (census_csv) as csvfile:
    csvreader = csv.reader(census_csv, delimiter = ',')

#
# for row in csvreader:




