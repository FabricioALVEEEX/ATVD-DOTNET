namespace MVCDOTNET.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

public class Restaurante
        {
            public int Id { get; set; }
            public required string Nome { get; set; }
            public decimal Preco { get; set; }
        }