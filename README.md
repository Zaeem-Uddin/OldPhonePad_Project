# OldPhonePad_Project

## Overview

`OldPhonePadProcessor` simulates the functionality of an old mobile phone keypad. It converts a string of key presses into the corresponding text message. Each button on the keypad can represent multiple characters, and the `*` and `#` keys are used for special actions like backspace and sending the final message.

---

## Features

- Converts keypad input to text following old phone rules.
- Supports backspace (`*`), pause (` `), and send (`#`) operations.
- Handles invalid inputs gracefully.

---

## How to Use

1. Clone this repository.
2. Open the project in any C# IDE (e.g., Visual Studio).
3. Call the `OldPhonePad` method from the `OldPhonePadProcessor` class with the desired input string.

### Example Usage

```csharp
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("33#")); // Output: E
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("227*#")); // Output: B
Console.WriteLine(OldPhonePadProcessor.OldPhonePad("4433555 555666#")); // Output: HELLO
