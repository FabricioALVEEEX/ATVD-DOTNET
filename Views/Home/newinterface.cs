using System.Collections;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using MVCDOTNET.Models;
using System.Collections.Generic;


namespace MVCDOTNET.Models
{



    public interface INewinterface
    {

        class RestauranteView
        {
            public void Exibirccomidas(List<Restaurante> comidas)
            {
                Console.WriteLine("=== Lista de ccomidas Disponíveis ===");
                foreach (var comida in comidas)
                {
                    Console.WriteLine($"ID: {comida.Id}, Nome: {comida.Nome}, Nome: {comida.Nome}, Preco: R${comida.Preco:F2}");
                }
                Console.WriteLine("===================================");
            }
        }
    }
}