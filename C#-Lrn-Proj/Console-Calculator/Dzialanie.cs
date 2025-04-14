namespace chatgpt;

public class Dzialanie
{
    public float Number1 { get; set; }
    public float Number2 { get; set; }
    public string Sign { get; set; }
    public float Result { get; set; }

    public Dzialanie(float number1, float number2, string sign, float result)
    {
        this.Number1 = number1;
        this.Number2 = number2;
        this.Sign = sign;
        this.Result = result;
    }

    public override string ToString()
    {
        return $"{Number1} {Sign} {Number2} = {Result}";
    }
}