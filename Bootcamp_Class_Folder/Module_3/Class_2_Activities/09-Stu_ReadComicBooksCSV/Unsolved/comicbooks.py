import os

import csv

csvpath = os.path.join('..', 'Resources', 'comic_books.csv')

found = False

book = input("What title are you searching for")

with open (csvpath, encoding='utf') as csvfile:
    csvreader = csv.reader(csvfile, delimiter = ',')

    for row in csvreader:
        if row[0] == book
        print(row[0] + " was published by " + row[8] + "in " + row [9])

        found = True

        if found is False:
            print("Sorry")
