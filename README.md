# Smart Shopping Cart Application

Welcome to the Smart Shopping Cart Application repository! This console-based application allows users to simulate shopping at various stores within a mall environment. Users can add and remove items from their cart, view their cart contents, and calculate the total cost of their purchases.

## Table of Contents
- [Overview](#overview)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)

## Overview

Smart Shopping Cart Application is a console-based program that enables users to manage their shopping experience conveniently. It supports interactions with different types of stores such as grocery stores and clothing stores, offering a seamless shopping simulation.

## Installation

To set up this project locally, follow these steps:

1. Clone the repository:
    ```bash
    git clonehttps://github.com/muathmm/Smart-Cart.git
    ```
2. Navigate to the project directory:
    ```bash
    cd Smart-Shopping-Cart
    ```
3. Compile and run the application.

## Usage

Run the application in your preferred development environment or terminal. Follow the on-screen prompts to navigate and interact with the shopping cart simulation.

## Project Structure

The project structure is organized as follows:

- **SmartShoppingCartTests/**: Contains unit tests for the application.
  - `ShoppingCartTest`: Includes tests to validate cart operations using Xunit.

- **SmartShoppingCart/**: Main project folder containing the application code.
  - `Program.cs`: Entry point (Main method) for starting the application.
  - `Product.cs`: Defines the Product class representing items available for purchase.
  - `ShoppingCart.cs`: Manages the shopping cart operations (add, remove, view items, calculate total cost).
  - `GroceryStore.cs`, `ClothingStore.cs`: Classes representing different stores with methods to display products and interact with the cart.
  - `ProductGenerator.cs`: Generates random products with varying attributes (name, price, category).

## Features

### Basic Features
- **Add Items**: Add products from different stores to the shopping cart.
- **Remove Items**: Remove products from the shopping cart as needed.
- **View Cart Contents**: Display the list of items currently in the cart.
- **Calculate Total Cost**: Calculate and display the total cost of all items in the cart.

### Additional Features
- **Store Interaction**: Browse products and select items from various simulated stores.
- **User-Friendly Interface**: Console-based interface with intuitive prompts and options for easy navigation.
- **Error Handling**: Handle scenarios where users try to add or remove items that do not exist.

## Contributing

Contributions to enhance the Smart Shopping Cart Application are welcome! Here's how you can contribute:

1. Fork the repository.
2. Create a new branch.
    ```bash
    git checkout -b feature-branch
    ```
3. Implement your changes and improvements.
    ```bash
    git commit -m "Description of changes"
    ```
4. Push to your fork.
    ```bash
    git push origin feature-branch
    ```
5. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE.txt](LICENSE.txt) file for details.

---

Enjoy your shopping experience with the Smart Shopping Cart Application!
