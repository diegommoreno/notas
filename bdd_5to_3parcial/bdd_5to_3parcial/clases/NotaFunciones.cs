using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdd_5to_3parcial.clases
{
    public class NotaFunciones
    {
            private readonly IMongoCollection<Notas> coleccion;

            public NotaFunciones()
            {
                var db = _2CConection.GetDatabase();
                coleccion = db.GetCollection<Notas>("Notas");
            }
                
            public List<Notas> ObtenerNotas()
            {
                return coleccion.Find(n => true).ToList();
            }
            
            public void CrearNota(Notas nota)
            {
                coleccion.InsertOne(nota);
            }

            public void ActualizarNota(Notas nota)
            {
                coleccion.ReplaceOne(n => n.Id == nota.Id, nota);
            }

            public void EliminarNota(string id)
            {
                coleccion.DeleteOne(n => n.Id == id);
            }
        }
    }

