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
