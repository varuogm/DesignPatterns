# Singleton

## when to use
when a class in your program should have just a single instance available to all clients. for example db connection wla instance throughout the program exceution .


### Main intution 


> Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.

> Create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create an object and saves it in a static field. All following calls to this method return the cached object

## Pros and Cons

### lazy load -
thread safety ka dhyan rakho . try make the block syncronised or lock until a single threads completes it exceution and then it will proceed accordingly.

### eager - 
eargerly in the start free foket ka object ban jayega shared memory me ,usee hota rhaga ek hi instance which is okay and ggood.. but what if program me jarurrt hi nhi padi and aise 100 eager instances pade ho.. faltu ka memory waste.. no not recomemnded.. 


- many test frameworks rely on inheritance when producing mock objects and yaha object to ban nhi tha bas kuch static methods expose karke kaam chalare , so it would be hard to Unit test single unit..
- voilated SRP as well (class should have only one reason to change and idher for creation of objects + class own methods both are there).
