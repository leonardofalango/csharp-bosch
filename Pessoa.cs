public class Pessoa
{
    public Pessoa (string nome, long cpf)
    {
        this.Nome = nome;
        this.cpf = cpf;
    }


    private long cpf;

    private string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    

    public string getCPF()
    {
        return cpf.ToString("000.000.000-00");
    }
    public void setCPF(string value)
    {
        cpf = long.Parse(
            value.Replace(".", "")
            .Replace("-", "")
        );
    }

    
}