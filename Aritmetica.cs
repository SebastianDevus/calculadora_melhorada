public class Aritmetica
{
    public static double RealizaSoma(double parcela1, double parcela2)
    {
        double total = parcela1 + parcela2;
        return total;
    }

    public static double RealizaSubtracao(double minuendo, double subtraendo)
    {
        double diferenca = minuendo - subtraendo;
        return diferenca;
    }

    public static double RealizaMultiplicacao(double fator1, double fator2)
    {
        double produto = fator1 * fator2;
        return produto;
    }
    
    public static double RealizaDivisao(double dividendo, double divisor)
    {
        if(divisor == 0)
        {
            throw new Exception("Não é possível dividir por zero!");
        }
        double quociente = dividendo / divisor;
        return quociente;
    }
}