// See https://aka.ms/new-console-template for more information

void Method1(object obj)
{
    if (obj is null)
    {
        throw new ArgumentNullException(nameof(obj));
    }
}

void Method2(object param)
{
    ArgumentNullException.ThrowIfNull(param);
}
