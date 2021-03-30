# PasswordControl
C# program which provides basic functionality to generate passwords, check the strength of passwords, and bruteforce passwords.

## Modules

### Password Generator
The generator uses C#'s native random number generator (this is not cryptographically secure) to generate a sequence of pseudo-random characters depending on the strength desired.
-Weak: Only lowercase alphabetic characters.
-Moderate: Only lower and uppercase alphabetic characters.
-Strong: Contains both sets of alphabetic characters alongside special characters (@,!,etc) and numbers.

Later this will incorporate a cryptographically secure random number generator alongside the native random number generator.

### Password Checker
Checks to see how strong a password is by calculating the password entropy and allocating the strength dependent on this value.
< 50  = Weak
< 75  = Moderate
< 100 = Strong
Alongside this it also determines the characters that are being used in the password such as Uppercase, lowercase, numbers, etc.

### Password Cracker
The password cracker uses a rudimentary algorithm which computes all permutations of possible passwords of length n in a simplistic space (only lowercase but can be easily extended to include all possible characters). Reasoning for the simplistic space is that the more characters added into the pool of potential characters causes the total number of passwords needing to be generated to increase exponentially. n^(number of possible characters), where n = length of password.

Alongside bruteforcing the password can also be checked against a User-Provided list or a list of common passwords which helps identify potential weak candidates regardless of password entropy (As more common passwords are checked against first).
