When I first looked at the problem statement, I knew that if I could format the input in arrays, I could complete the problem. 
If I could target each index, I could convert the strings to integers to perform the necessary math. Ultimately, that is the 
approach that I chose to use. 

As I thought more about the problem, my ideas spiraled into needless complications about whether I should use a database to store
the data, although the problem clearly states it is not necessary. As I traversed the problem, I tried to reminded myself that the simplest
answer would be best. Thus, I chose to write the problem in C# using objects. 

I chose to use objects because by creating an object called "trip," I could create a template for every trip. The template includes all of the 
properties in the correct data type that were going to be vital to solving the problem. This way, I could set each string array index conversion
equal to the object's properties. As a result, I could separate the trips into different silos and perform math operations on 
the .txt input file for each of them.

After I performed the math on each input string, I worked on sorting and filtering the results. I started by indicating that if 
the MPH was between 5 & 10, the input string would qualify for reporting. I added the mph property for each trip to a list called "doesQualify."
Once that was done, then I needed to sort each by distance. So, I isolated the doesQualify in an if/else statement and inside. To sort by
distance, I nested the distance property in another if/else statement. This worked.

I tested the code by putting the program into a separate file. I had a few bugs which needed to be fixed, but as far as I can tell, for whatever
variables are input through the .txt file, this code will work. I broke distance and qualify, the two factors that would affect the output, down
into every possibility. I tested the following and used a new doesQualify (doesQualify1, doesQualify2, etc.) list to test each option. 

Distance Property Comparison (with all trips qualifying for reporting e.g. if doesQualify.Contains(tripOne.mph))<br/>
1 = string[] trip1<br/>
2 = string[] trip2<br/>
3 = string[] trip3<br/>
1 > 2 and 3 & 2 > 3<br/>
1 > 2 and 3 & 3 > 2<br/>
2 > 1 and 3 & 1 > 3<br/>
2 > 1 and 3 & 3 > 1<br/>
3 > 2 and 1 & 1 > 2<br/>
3 > 2 and 1 & 2 > 1<br/>

Qualify and distance comparison<br/>
1 & 2 qualify and 1 > 2<br/>
1 & 3 qualify and 1 > 3<br/>
1 & 2 qualify and 2 > 3<br/>
1 & 3 qualify and 3 > 1<br/>
2 & 3 qualify and 3 > 2<br/>
2 & 3 qualify and 2 > 3<br/>
Only 1 qualifies<br/>
Only 2 qualifies<br/>
Only 3 qualifies<br/>
0 qualifies <br/>

I understand that this code and testing approach does not contain the scalability for a larger project. Testing every single outcome 
individually simply will not be an option in the future. However, this is where I am as a developer right now. I am confident that I 
can learn to code and test more efficiently with great management and mentorship. I look forward to the next steps! 


