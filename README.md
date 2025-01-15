# Polymorphism Example - Geometric Shapes

This project demonstrates the concept of **polymorphism** in C# by creating a base class `BaseGeometrikSekil` and deriving specialized classes `Kare`, `Dikdortgen`, and `DikUcgen`. Each derived class customizes the area calculation using the `AlanHesapla` method.

---

## Features

### Classes

#### **1. BaseGeometrikSekil (Base Class)**
- **Properties**:
  - `Genislik`: Represents the width of the shape.
  - `Yukseklik`: Represents the height of the shape.
- **Method**:
  - `AlanHesapla`: Calculates the area as `Genislik * Yukseklik`.
  - Defined as `virtual` to allow overriding in derived classes.

#### **2. Kare (Derived Class)**
- Inherits from `BaseGeometrikSekil`.
- **Overridden Method**:
  - `AlanHesapla`: Calculates the area of a square as `Genislik * Genislik`.

#### **3. Dikdortgen (Derived Class)**
- Inherits from `BaseGeometrikSekil`.
- Uses the base class implementation of `AlanHesapla` to calculate the area as `Genislik * Yukseklik`.

#### **4. DikUcgen (Derived Class)**
- Inherits from `BaseGeometrikSekil`.
- **Overridden Method**:
  - `AlanHesapla`: Calculates the area of a right triangle as `(Genislik * Yukseklik) / 2`.

---

## Example Usage

### Code
```csharp
using PolymorphismExample;

BaseGeometrikSekil kare = new Kare
{
    Genislik = 10,
    Yukseklik = 10,
};
Console.WriteLine("Karenin Alanı: " + kare.AlanHesapla());

BaseGeometrikSekil dikdortgen = new Dikdortgen
{
    Genislik = 10,
    Yukseklik = 25,
};
Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla());

BaseGeometrikSekil dikUcgen = new DikUcgen
{
    Genislik = 10,
    Yukseklik = 30,
};
Console.WriteLine("Dik Üçgenin Alanı: " + dikUcgen.AlanHesapla());
```

### Output
```
Karenin Alanı: 100
Dikdörtgenin Alanı: 250
Dik Üçgenin Alanı: 150
```

---

## Concepts Demonstrated

### 1. **Polymorphism**
- The `AlanHesapla` method in the base class is overridden in derived classes to provide specific implementations for each shape.

### 2. **Inheritance**
- Common properties (`Genislik` and `Yukseklik`) and methods are defined in the base class and reused in derived classes.

### 3. **Encapsulation**
- The properties and methods are encapsulated within their respective classes, ensuring clean and modular code.

---

## How to Extend

- Add additional shapes (e.g., `Cember`, `Elips`) by deriving new classes from `BaseGeometrikSekil`.
- Implement additional methods like `CevreHesapla` for perimeter calculations.
- Add validations to ensure `Genislik` and `Yukseklik` are positive values.

---

## Summary
This example highlights how polymorphism simplifies the implementation of shape-specific behavior while sharing common properties and methods. It allows for scalability and reusability in object-oriented programming.

