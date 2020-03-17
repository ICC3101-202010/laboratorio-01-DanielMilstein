using System;

[System.Runtime.InteropServices.ComVisible(true)]
[System.Serializable]
public class Random
{
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    internal static void Next()
    {
        throw new NotImplementedException();
    }

}
