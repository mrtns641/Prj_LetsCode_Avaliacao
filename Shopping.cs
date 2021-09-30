using System;
using System.Collections.Generic;

namespace Prj_LetsCode_Avaliacao
{

    //classe onde as listas de lojas ficarão armazenadas
    public class Shopping
    {
        List<FastFood> fastFoods = new List<FastFood>();
        List<SelfService> selfServices = new List<SelfService>();
        List<LojaPassagens> lojasPassagens = new List<LojaPassagens>();


        //adiciona um fast food na lista de fast foods
        public void AddFastFood(FastFood fastFood){
            fastFoods.add(fastFood);
        }

        /*adiciona um restaurante self service na lista de 
        restaurantes self services */
        public void AddSelfService(SelfService selfService){
            selfServices.add(selfService);
        }

        /*adiciona uma loja de passagens na lista de 
        lojas de passagens */
        public void AddLojaPassagens(LojaPassagens lojaPassagens){
            lojasPassagens.add(lojaPassagens);
        }

        public void ListarFastFoods(){
            foreach (Loja loja in fastFoods)
            {
                Console.WriteLine(loja.Nome)
            }
        }

        public void ListarSelfServices(){
            foreach (Loja loja in selfServices)
            {
                Console.WriteLine(loja.Nome)
            }
        }

        public void ListarLojasDePassagens(){
            foreach (Loja loja in lojaPassagens)
            {
                Console.WriteLine(loja.Nome)
            }
        }
    }
}