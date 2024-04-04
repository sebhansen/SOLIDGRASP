# SOLID-GRASP

This project is a demonstration of SOLID and GRASP principles in object-oriented design.

## Table of Contents

- [Introduction](#introduction)
- [SOLID Principles](#solid-principles)
  - [Single Responsibility Principle (SRP)](#single-responsibility-principle-srp)
  - [Open/Closed Principle (OCP)](#openclosed-principle-ocp)
  - [Liskov Substitution Principle (LSP)](#liskov-substitution-principle-lsp)
  - [Interface Segregation Principle (ISP)](#interface-segregation-principle-isp)
  - [Dependency Inversion Principle (DIP)](#dependency-inversion-principle-dip)
- [GRASP Principles](#grasp-principles)
  - [Controller](#controller)
  - [Creator](#creator)
  - [Information Expert](#information-expert)
  - [High Cohesion](#high-cohesion)
  - [Low Coupling](#low-coupling)

## Introduction

SOLID and GRASP are fundamental principles in object-oriented design. They help in creating maintainable, scalable, and flexible software systems.

## SOLID Principles

### Single Responsibility Principle (SRP)

Each class should have only one reason to change. It should have only one responsibility.

### Open/Closed Principle (OCP)

Software entities should be open for extension but closed for modification.

### Liskov Substitution Principle (LSP)

Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.

### Interface Segregation Principle (ISP)

A client should never be forced to implement an interface that it doesn't use, or clients shouldn't be forced to depend on methods they do not use.

### Dependency Inversion Principle (DIP)

High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions.

## GRASP Principles

### Controller

Assigns responsibility for handling system events (like button clicks, etc.) to a non-UI class.

### Creator

Assigns the responsibility for creating new instances of objects to a class.

### Information Expert

Assigns a responsibility based on which class has the most information required to fulfill it.

### High Cohesion

A class should have a single, well-focused purpose.

### Low Coupling

Minimizes the dependencies between classes.
