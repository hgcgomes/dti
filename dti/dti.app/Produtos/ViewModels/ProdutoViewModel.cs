using dti.app.ViewModels;

namespace dti.app.Produtos.ViewModels
{
  public class ProdutoViewModel : ViewModel
  {
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorUnitario { get; set; }
  }
}
