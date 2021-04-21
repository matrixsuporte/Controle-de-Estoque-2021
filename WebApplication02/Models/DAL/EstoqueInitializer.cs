using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication02.Models.DAL
{
    public class EstoqueInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WebAplicationContext>
    {
        protected override void Seed(WebAplicationContext context)
        {
            //var produtos = new List<Produto>
            //{
            //    //new Produto{Nome="item 1", Preco=1}
                
            //    new Produto{Nome="ABACAXI DESIDRATADO EM RODELAS",Preco=292.10},
            //    new Produto{Nome="ABACAXI DESIDRATADO EM RODELAS",Preco=62.10},
            //    new Produto{Nome="ACAFRAO CURCUMA MOIDO",Preco=11.60},
            //    new Produto{Nome="ACAFRAO CURCUMA MOIDO",Preco=109.60},
            //    new Produto{Nome="ACAI EM PO",Preco=56.05},
            //    new Produto{Nome="ACAI EM PO",Preco=1318.25},
            //    new Produto{Nome="ACUCAR DE COCO",Preco=267.12},
            //    new Produto{Nome="ACUCAR DE COCO",Preco=28.35},
            //    new Produto{Nome="ACUCAR DE CONFEITEIRO",Preco=80.61},
            //    new Produto{Nome="ACUCAR DE CONFEITEIRO",Preco=8.55},
            //    new Produto{Nome="ACUCAR DE MACA",Preco=79.55},
            //    new Produto{Nome="ACUCAR DE RAPADURA (RAPA SUGAR) SEM ADICAO DE ACUCAR",Preco=17.35},
            //    new Produto{Nome="ACUCAR DEMERARA",Preco=4.40},
            //    new Produto{Nome="ACUCAR DEMERARA",Preco=103.54},
            //    new Produto{Nome="ACUCAR MASCAVO JOCAL",Preco=5.70},
            //    new Produto{Nome="ACUCAR MASCAVO JOCAL",Preco=107.28},
            //    new Produto{Nome="ACUCAR MASCAVO DOCICAN",Preco=5.30},
            //    new Produto{Nome="ACUCAR MASCAVO DOCICAN",Preco=124.70},
            //    new Produto{Nome="ACUCAR ORGANICO CLARO",Preco=3.70},
            //    new Produto{Nome="ACUCAR ORGANICO CLARO",Preco=87.04},
            //    new Produto{Nome="AGAR-AGAR",Preco=378.25},
            //    new Produto{Nome="AGUA DE COCO EM PO",Preco=101.25},
            //    new Produto{Nome="ALBUMINA",Preco=58.50},
            //    new Produto{Nome="ALBUMINA SABOR BANANA",Preco=71.00},
            //    new Produto{Nome="ALBUMINA SABOR BAUNILHA",Preco=71.00},
            //    new Produto{Nome="ALBUMINA SABOR CHOCOLATE",Preco=71.00},
            //    new Produto{Nome="ALBUMINA SABOR MORANGO",Preco=71.00},
            //    new Produto{Nome="ALECRIM",Preco=14.25},
            //    new Produto{Nome="ALFARROBA EM PO",Preco=50.65},
            //    new Produto{Nome="ALHO CEBOLA E SALSA",Preco=36.25},
            //    new Produto{Nome="ALHO CEBOLA E SALSA",Preco=342.50},
            //    new Produto{Nome="ALHO CEBOLA E SALSA SEM SÓDIO",Preco=36.25},
            //    new Produto{Nome="ALHO CEBOLA E SALSA SEM SÓDIO",Preco=342.50},
            //    new Produto{Nome="ALHO DESIDRATADO FRITO",Preco=26.10},
            //    new Produto{Nome="ALHO EM FLOCOS DESIDRATADO",Preco=28.30},
            //    new Produto{Nome="ALHO EM FLOCOS DESIDRATADO",Preco=641.76},
            //    new Produto{Nome="ALHO EM PO",Preco=18.15},
            //    new Produto{Nome="ALHO EM PO",Preco=428.75},
            //    new Produto{Nome="ALHO GRANULADO",Preco=548.00},
            //    new Produto{Nome="ALHO GRANULADO",Preco=23.20},
            //    new Produto{Nome="ALHO PORO",Preco=39.15},
            //    new Produto{Nome="ALHO PORO",Preco=369.90},
            //    new Produto{Nome="ALL BRAN",Preco=15.70},
            //    new Produto{Nome="ALL BRAN",Preco=147.72},
            //    new Produto{Nome="AMACIANTE DE CARNE",Preco=9.60},
            //    new Produto{Nome="AMARANTO EM FLOCOS",Preco=25.65},
            //    new Produto{Nome="AMARANTO EM FLOCOS",Preco=603.25},
            //    new Produto{Nome="AMARANTO EM GRAO",Preco=24.25},
            //    new Produto{Nome="AMARANTO EM GRAO",Preco=571.25},
            //    new Produto{Nome="AMEIXA SEM CAROCO",Preco=309.40},
            //    new Produto{Nome="AMEIXA SEM CAROCO",Preco=32.90},
            //    new Produto{Nome="AMENDOA CONFEITADA BRANCA",Preco=33.75},
            //    new Produto{Nome="AMENDOA CONFEITADA BRANCA",Preco=317.50},
            //    new Produto{Nome="AMENDOA CONFEITADA COLORIDA",Preco=317.50},
            //    new Produto{Nome="AMENDOA CONFEITADA COLORIDA",Preco=33.75},
            //    new Produto{Nome="AMENDOA DEFUMADA",Preco=47.25}
            //};

            //produtos.ForEach(s => context.Produtos.Add(s));
            //context.SaveChanges();
        }
    }
}