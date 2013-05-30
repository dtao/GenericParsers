Generic Parsers
===============

This is a humble little library to make parsing text input to typed objects a bit less painful in .NET.

Motivation
----------

Here's a pretty common scenario: you need to parse a document containing many values for different keys. For each key, you're expecting a certain type of value; so you need to parse the data using `int.Parse`, `DateTime.Parse`, etc. But you *don't* want to write a huge `switch` statement calling a different method for each type. You could use the `System.Convert` class; but this approach is neither flexible (e.g., you might want to fail gracefully using `TryParse` rather than throw an exception) nor extensible (what if your data includes values for types that `System.Convert` can't parse?).

Here's another scenario: you want to write a generic method whose logic includes a parsing step. (As a somewhat trivial example, this library includes two extension methods on `IEnumerable<T>`: `ParseAll` and `TryParseAll`.)

The .NET BCL already includes a nice solution to similar problems when comparing objects for either sorting or equality:

```csharp
// Used for generic sorting-related methods (e.g. IEnumerable<T>.OrderBy)
IComparer<T> comparer = Comparer<T>.Default;

// Used for generic equality-related methods (e.g., IEnumerable<T>.Distinct)
IEqualityComparer<T> comparer = EqualityComparer<T>.Default;
```

The Generic Parsers library gives you the same thing for its own `IParser<T>` interface:

```csharp
// Never write a switch statement for parsing types again!
IParser<T> parser = Parser<T>.Default;

// Examples:
Parser<int>.Parse("123"); // 123
Parser<double>.Parse("3.14"); // 3.14
Parser<bool>.Parse("True"); // true
```

Implementation
--------------

A lot of the code in this project is just boilerplate. I didn't feel like hand-writing it, so it was generated using Ruby and [Mustache](http://mustache.github.io/) (see the "templates" folder).

In my opinion this is actually a very nice strategy for authoring boilerplate-heavy projects; and for those of you in the Java and .NET worlds who've never used it before, I encourage you to consider it.
