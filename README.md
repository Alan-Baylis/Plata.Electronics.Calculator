# Plata.Electronics.Calculator
A C# library for doing calculations in electronics field

## Ohm's Law

### Unknown Voltage

```c#
Current current = Current.make(2);
Resistance resistance = Resistance.make(1000);

Voltage voltage = OhmsLaw.calculate(current, resistance);
// voltage = 2000
```

### Unknown Current

```c#
Voltage voltage = Voltage.make(5);
Resistance resistance = Resistance.make(100);

Current current = OhmsLaw.calculate(voltage, resistance);
// current = 0.5
```

### Unknown Resistance

```c#
Voltage voltage = Voltage.make(12);
Current current = Current.make(0.5F);

Resistance resistance = OhmsLaw.calculate(voltage, current);
// resistance = 24
```

## Resistor encoder/decoder

```c#
Resistor resistor = new Resistor(230);

Color firstBand = resistor.FirstBand; // Red

Color secondBand = resistor.SecondBand; // Orange

int multiplier = resistor.Multiplier;

float value = resistor.Value; // 230
```

## Number System
