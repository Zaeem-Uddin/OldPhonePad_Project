
---

### **Documentation**

#### **Class: OldPhonePadProcessor**

| **Method**         | **Description**                                                                 |
|---------------------|---------------------------------------------------------------------------------|
| `OldPhonePad`       | Converts keypad input to text based on old phone rules.                        |
| `AppendCharacter`   | Appends a character to the result based on key and press count. (Internal use) |

##### **Method: OldPhonePad**
- **Signature:** `public static string OldPhonePad(string input)`
- **Parameters:**  
  - `input`: A string representing keypad input. Must end with `#`.
- **Returns:**  
  - The text message as a string.
- **Throws:**  
  - `ArgumentException` if the input is invalid or does not end with `#`.

##### **Keypad Mapping**

| Key | Characters | Notes                   |
|-----|------------|-------------------------|
| 1   |            | No characters assigned. |
| 2   | A, B, C    | Cycles through letters. |
| 3   | D, E, F    |                         |
| 4   | G, H, I    |                         |
| 5   | J, K, L    |                         |
| 6   | M, N, O    |                         |
| 7   | P, Q, R, S |                         |
| 8   | T, U, V    |                         |
| 9   | W, X, Y, Z |                         |
| 0   | Space      |                         |

---

