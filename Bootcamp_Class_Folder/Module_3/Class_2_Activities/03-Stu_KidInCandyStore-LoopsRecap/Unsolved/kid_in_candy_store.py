# The list of candies to print to the screen
candy_list = ["Snickers", "Kit Kat", "Sour Patch Kids", "Juicy Fruit", "Swedish Fish", "Skittles", "Hershey Bar", "Starbursts", "M&Ms"]

# The amount of candy the user will be allowed to choose
allowance = 5

# The list used to store all of the candies selected inside of
candy_cart = []
print()
print("Hello, here is our candy!")

print()


print(f'----------------------')

print()


# this is one way to do it with enumerate. 
#for candy, item in enumerate(candy_list, start=1):
    #print("[" + str(candy) + "]", item)
for candy in candy_list:
    print(f'[{str(candy_list.index(candy))}] {candy}')

    #f'  ' this is string formatting and it converts everything 
    #between the single quote into a string we need {} to denote non string objects. 
print()
print(f'----------------------')
print()
print(f'Please enter the index number of the candy you\'d like.')
print()
for x in range(allowance):
    selected = input(f'Please enter the index number of the candy you\'d like: ')
    
    candy_cart.append(candy_list[int(selected)])

    print(f'This is whats in your cart: {candy_cart}')
if len(candy_cart) == allowance:
    print("Thats enough candy for you.")



