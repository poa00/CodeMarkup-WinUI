﻿namespace ExampleApp
{
    public partial class BorderPage
    {
        class Sources
        {
            public const string Sample1 =
$@"new Border()
    .BorderThickness(10)
    .BorderBrush(Colors.Red)
    .Background(Colors.Black)
    .Child(
        new TextBlock().Text(""I'm in border"")
    )";

        };
    }
}
