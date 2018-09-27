This file has a brief description for each piece of the book distribution system

Main:

	The main is visually represented as a basic WinForms GUI. Enter a card number
	and the amount of books to order then click order to watch the order begin.
	Valid card numbers are between 5000 and 7000. Order amounts are any integer.
	Upon start up main will start a background thread to monitor the multicellbuffer.
	The order button will spawn publisher threads if there are less than 2. The logic
	for spawning publisher threads just keeps trying to spawn the max. If there are
	2 running then the 2 publishers threads will competively fight for the new order. 
	We don't care which one gets it. There are manny methods in main that are simply 
	to update GUI controls, they almost all start with "set".
	
MultiCellBuffer:

	This class has all of the shared data, including of course the buffer. Which I
	have implemented as just an array of strings with size 3. It is initialized to null
	in every cell and then when a new string is encoded by the bookstore a bool is set
	by the bookstore letting buffer thread know that there is a new encoded string ready
	to be put in the buffer. There are a number of other shared static booleans and
	counters in this class.
	
Publisher:

	The publisher is spawned by the main as described above. Once the publisher is spawned
	it will update the shared thread count variable and then calculate the unit price based on
	amount of books ordered. The publisher thread will use the pricing model function in the
	publisher class to determine whether or not there is a price cut and then raise an event
	which the main is subscribed to and bookstore has the event handler. The publisher thread
	will also always spawn a bookstore thread if there is less than 5 running when a new order is
	placed. This newly spawned bookstore may not be the bookstore that encodes the order if other
	bookstores are running. After the bookstore encodes the order then the publisher will decode 
	the order and spawn an order processing thread to finish off the process. 1 publisher thread
	dies if the number of price cuts increments to 20. Both publishers are incrementing the same 
	price cuts counter.
	
PricingModel:

	This is a function inside the Publisher class that calculates the unit price. It takes the 
	amount of books as the input and generates a random double between 50 and 200. It will raise
	a price cut event if the amount is greater than 10 and begin decreasing the price.

Bookstore:

	As described in the publisher a bookstore thread is spawned by the publisher every time a
	new order is created and if the number of bookstores running is less than 5. Once a bookstore
	is spawned it will wait for a publisher to tell it that a price has been calculated on a new 
	order. If there are multiple bookstores running then they will fight over who gets to encode 
	the order using the calculated price from the publisher.
	
OrderProcessing:

	This thread is spawned by the publisher after the bookstore has encoded the order. The publisher
	thread that spawns this thread may be different than the one that spawns the bookstore thread,
	but this is still the same order. The order processing thread does minimal work. It will convert
	the decoded string array into usable ints. It will check the valitidy of the card number and 
	calculate the total price. 
	
OrderClass:

	This class contains the order information and all the corresponding get methods and set methods.
	
Encoder:

	This class will encode the order information into a single string separated by #'s.
	
Decoder:

	This class will decode the encoded string into an array of strings.