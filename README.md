# C-sharp-tick-system
Student project: a prototype of Ticketing system using C#, Windows forms and UDP protocol. 
## Objectives
The goal is a prototype of the ticketing system, which could recieve Help Desk Tickets from the staff member, could display all tickets, provide opportnity to respond or reopen any ticket, display statistics. Application has a graphic interface (Windows Forms) and consists of two parts: 
## Help Desk Client
This app provides functionality to collect a help desk request from a staff member then send data to "server" part which will store and handle the Help Desk ticket. 
### Files
- program.cs (starts the "client" App and open the form for data collection. On submission the client app sends data to "server" part via UDP protocol. (?? port))
- Form1.cs (graphic interface)

## Ticketing system
This is a "server" part of the system. It recieves and stores all tickets, also provides the opportunity to respond it. App has main thread to handle tickets and all help desk processes, and second thread which is "listening" the port # and provides communications between client and server. 
The system doesn't include any real database to store data as it was not required. All data will disappear as soon as you close the application. :)

### Files
- program.cs (inicialises the Ticketing system)
- Ticket.cs (a module for Ticket class. Each ticket has several attributes (creator's name and staff ID, the description of the issue, IT response, status, etc))
- TicketForm.cs (a graphic interface for entering/editing a ticket)
- PasswordGenerator.cs (a module for the class generating a password following certain rools in case the issue contains words "change" and "password".)
- Ticketing system.cs (a module for ticketing system class. On initialising starts the second thread listening to port=5678 and invokes the creation of the new ticket if the data recieved from client. Also provides interaction with GUI).
- Ticket Form.cs (supports GUI and sends data to port=5678 when data submitted)
- TicketStats.cs (a structure and functionality of Ticketing system + statistics)

# C-sharp-tick-system
**Project Overview:**
C-sharp-tick-system is a student project that serves as a prototype of a Ticketing System using C#, Windows Forms, and the UDP protocol.

## Objectives
The primary objective of this project is to create a functional prototype of a ticketing system. This system is designed to receive Help Desk Tickets from staff members, display all tickets, allow responses, reopen tickets, and provide statistics. The application utilizes a graphical interface built using Windows Forms and is divided into two main components:

## Help Desk Client
The Help Desk Client application is responsible for collecting help desk requests from staff members. It then transmits this data using UDPClient to the server component , which stores and manages the Help Desk tickets.

### Files
- `program.cs`: Initializes the Help Desk Client application and opens the data collection form. Upon submission, the client app sends data to the server component via the UDP protocol.
- `Form1.cs`: Provides the graphical user interface.

## Ticketing System (Server)
The Ticketing System is the server-side part of the system. It receives, stores, and allows responses to all tickets. The application includes a main thread responsible for handling tickets and help desk processes, as well as a second thread that listens on a specified port for communications between the client and server. Notably, this system does not utilize a real database for data storage; all data  will disappear when the application is closed.

### Files
- `program.cs`: Initializes the Ticketing System.
- `Ticket.cs`: A module for the Ticket class, which includes attributes such as the creator's name and staff ID, issue description, IT response, status, and more.
- `TicketForm.cs`: Provides a graphical interface for entering and editing tickets and communication with the server part.
- `PasswordGenerator.cs`: A module for generating passwords following specific rules when the issue contains the words "change" and "password."
- `Ticketing system.cs`: Supports the interaction with GUI. It initializes a second thread that listens on port 5678 and handles the creation of new tickets when data is received from the client.
- `TicketStats.cs`: Defines the structure and functionality of the Ticketing System, including statistics.
