# Task Instructions

1) Apply at least two of the following practices:

- [YES] Test-Driven Development (TDD): Write a failing test first, then implement.
- [NO] Pair Programming: Work with a peer (virtually or in-person) on a small task.
- [NO] Continuous Integration: Simulate automated builds or tests.
- [YES] Simple Design: Focus on only what is needed now.

2) Bring the Customer Perspective

- [MARKETING DEPT.] Identify a “customer” for your exercise (could be a peer or imaginary user).
- Write at least one user story and define simple acceptance criteria.

  - The User Story
  > As a Marketing Manager, I want the password validator to return all specific error
  > messages at once, rather than just a
  > generic "invalid" response, so that users know exactly how to fix their password
  > without getting frustrated and
  > abandoning the sign-up funnel.

  - The Acceptance Criteria (Given / When / Then)
    - Scenario 1: Perfect Password
  > Given a new user is choosing a password
  > When they enter "Marketing_Wins1" (meets length, capital, and underscore rules)
  > Then the validator should return a success status with no errors.
    - Scenario 2: Single Rule Violation
  > Given a new user is choosing a password
  > When they enter "marketing_wins" (missing a capital letter)
  > Then the validator should return a failure status with the specific message: "Password must contain at least one capital letter."
    - Scenario 3: Multiple Rule Violations (The friction-saver)
  > Given a new user is choosing a password
  > When they enter "short" (fails length, fails capital, fails underscore)
  > Then the validator should return a failure status with a list of all three specific errors, so the user can fix them all on their next try.

- [TODO] Test your implementation against these criteria.


3) Refactor and Iterate

- [DONE] Refactor your code based on what you learned while testing.
- Note any improvements in clarity, simplicity, or maintainability.
  - Adding rules via constructor parameter allows me to reuse the same class with different base rules

# Indentified next steps

- Convert rules dictionary into typed record
- Conver Rule into a class with Interface

# Kata Instructions

Iteration 2 - Rules abstraction Goal

Design and implement software that can adapt to different password validation rules TDD and focus on the OOP principles.

Let's pretend that now we want to create another type of password validations because on our app we need different type
of passwords, such as:

Validation 2:

    Have more than 6 characters
    Contains a capital letter
    Contains a lowercase
    Contains a number

Validation 3:

    Have more than 16 characters
    Contains a capital letter
    Contains a lowercase
    Contains an underscore

Things to practice

In this iteration, we should try to identify a good abstraction and try to work on OOP principles as well as on design
patterns like Builder and Factory Interesting restrictions

Use object calisthenics. Iteration 3 - Multiple errors Goal

Now we can know if a password is valid or not, but we cannot understand why, in this iteration, we should be able to
return a list of errors for each invalid password, so we could know why the password it's not valid. Things to practice

Identify how maintainable it's the code that you've built so far, and how it adapts to change, this iteration could
change depending on the programming language that you use. Iteration 4 - Validation strategy Goal

Up untill this point we've been able to create a list of validation rules and validate the password passes all the
validation rules, but now we want a new password with the same rules but allowing to fail only one of them.

Validation 4

    Have more than 8 characters
    Contains a capital letter
    Contains a number
    Contains an underscore

Examples:

    Have more than 8 characters ✅
    Contains a capital letter ✅
    Contains a number ✅
    Contains an underscore ❌

This password it's a valid password Things to practice

This will help to enforce encapsulation for the lists of rules and have a better design for validation
strategies [preventing us from using inheritance], this also could help us work on the Strategy pattern.