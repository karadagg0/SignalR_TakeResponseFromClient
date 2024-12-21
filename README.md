# SignalR Take Response from Client

## Overview
This project demonstrates how to handle client-server communication using SignalR in .NET. It shows how to take responses from the client after sending a message, and how to use SignalR for real-time messaging.

## Features
- Real-time client-server communication using SignalR.
- Client can send and receive messages.
- Server can send a message and wait for a response from the client.

## Setup

### Prerequisites
- .NET SDK 7.0 or later.
- Visual Studio or Visual Studio Code.
- SignalR client and server libraries.

### Installation
1. Clone the repository:
    ```bash
    git clone https://github.com/karadagg0/SignalR_TakeResponseFromClient.git
    ```
2. Install dependencies:
    ```bash
    dotnet restore
    ```

### Running the Application
1. Run the server:
    ```bash
    dotnet run --project Server
    ```
2. Run the client:
    ```bash
    dotnet run --project Client
    ```

### Usage
- The client connects to the server via SignalR and sends a message.
- The server processes the message and responds back to the client.
- The client handles the response and displays it.

