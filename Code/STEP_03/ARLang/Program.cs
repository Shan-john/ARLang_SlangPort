using OneOf;

Console.WriteLine();



[GenerateOneOf]
public partial class MyUnion : OneOfBase<One, Two, Three, Four>;
public record One;
public record Two;
public record Three;
public record Four;