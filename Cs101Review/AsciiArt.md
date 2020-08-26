# <span>ASCII Art in C#: Using Verbatim String Literals</span>
It's a lot of fun to create ASCII art in C#, but there are a few issues that can arise with certain characters.

Let's say we want to create a bat. We found a decent-looking ASCII art bat online, and it looks like this:
```
  _   ,_,   _
 / `'=) (='` \
/.-.-.\ /.-.-.\ 
`      "      `
```

Now, we try to put that in C# with the following code:
```cs
Console.WriteLine("  _   ,_,   _   ");
Console.WriteLine(" / `'=) (='` \  ");
Console.WriteLine("/.-.-.\ /.-.-.\ ");
Console.WriteLine("`      '      ` ");
```

Looks good, right? But when we try to run it, we get a bunch of errors! What's happening here?

## Escape Sequences
The problem is that C# is on the lookout for [escape sequences](https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019). Every time it sees a backslash (`\`), it thinks we are trying to create a special character! Our bat contains several backslashes, so it gets tripped up. What we want to do is _avoid_ these escape sequences, and treat the backslashes as regular text. How can we do that?

## Verbatim String Literals
[Verbatim string literals](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim) are a way to tell C# that we don't want to use any escape sequences, we just want the raw text. Instead of giving us errors, or converting our backslash sequences to other symbols, it will keep the text _as-is_.

To create a verbatim string literal, simply add an `@` before the opening quote! Returning to our bat example, here's all we have to do to make it work:
```cs
Console.WriteLine(@"  _   ,_,   _   ");
Console.WriteLine(@" / `'=) (='` \  ");
Console.WriteLine(@"/.-.-.\ /.-.-.\ ");
Console.WriteLine(@"`      '      ` ");
```

Another great thing about verbatim strings is that we can easily combine multiple lines! Instead of using the four `Console.WriteLine` statements above, we can use _one_ `Console.WriteLine` statement that contains each line for the bat. All we have to do is make a new line in between the opening and closing double quotes. Make sure not to indent any of the text; since it's verbatim, those extra spaces will be in the final text!

It should look something like this:
```cs
Console.WriteLine(@"
  _   ,_,   _   
 / `'=) (='` \  
/.-.-.\ /.-.-.\
`      '      `
");
```

Using verbatim string literals makes it much easier to work with ASCII art. For more information about how to find and create ASCII art, check out [this article](http://programmingisfun.com/command-line-ascii-design/). Just make sure to start your strings with an `@` symbol!