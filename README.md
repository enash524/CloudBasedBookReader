## Design an online cloud-based book reader

Your job is to design an online cloud-based book reader. The online book reader will be a web application designed
for reading online eBooks based on user subscription. After a user registers with the system, the user can search the
book repository and check out a book for reading. A user can create a bookmark to resume reading the book later
from where they left off. The subscription will be based on the users remaining available reading hours during a given
time period. The User will be limited to checking out a fixed number of books concurrently based on their
subscription level. Once a user has finished reading an eBook, the book will automatically be checked back into the
system.

## Product Function

**OnlineSystem**

* Check to see if user subscription is valid before allowing reading
* Stop user from being able to read once reading credit hours expire
* Store total number of reading hours and checked out books by user
* Allow user to resume reading (start reading hours)
* Allow user to pause reading (stop reading hours)
* Allow multiple users to read same book at the same time
* Allow multiple user to check out same book
* Notify any new book added to the system

**Client**

* register with the system
* search available books
* Checkout the book(s)
* Book mark/ pause the reading
* Resume reading from last page read
* Finish reading (check in the book)
* Provide management screen with account information (subscription details)
  * No. of reading hours left
  * Number of books checked out against total limit

**Administrator**

* Accept user registration (create Account/Subscription)
* Add book
* Delete book
* User(s) information
* View book(s) information
    * Total number of time book(s) are viewed
    * Number of users currently reading the book
* Configure/Apply Subscription rule
    * Guest User
    * Silver User
    * Gold User
    * Platinum User
* User Management
    * User Information
    * User discount
    * User status (Active/paused/deleted)

## Design Considerations

**Suggested classes:**

* OnlineSystem
* Client
* Administrator
* Book
* Library
* Others?

**Design critical-to-quality outputs (CTQ):**

Scalability (System should be able to handle large number of users)

Performance.

* Consider performance while searching the book.
* Consider performance when user pause and resume reading.
* Consider using Caching

Security.

* Authentication/Authorization

## Design Output (Deliverables)

**Design output (Deliverables):**

* UML diagrams – Logical, development (Sequence)and deployment
* High level use case diagram
* C# Class Skeletons for the Suggested Classes above
* Apply SOLID principles and explanation where ever applicable
* Explain design pattern(s) applicable to achieve product requirements
* Any other supporting UML diagram to explain above defined requirements
* Architecture cross-cutting concerns. (e.g. Authentication, security etc.)
* Database design (**optional**)
