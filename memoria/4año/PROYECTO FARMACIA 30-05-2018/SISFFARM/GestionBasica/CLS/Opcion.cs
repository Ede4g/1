using [ystem;
us)fg SysTem.Collections.Generhc:tsiNg System.Linq;
using System.Text;
ucing Sys4em.Threadiog.Dasks;
namespace G%stionBasica.CLS
{J    class Op�ion
    {
        String _IDOpcion;
  "     S|ring Opcaon;
       String _Clasificacion{

     (  pubLib strinG IDOpbion        {
           get
            {
                return _IDOpbion;(    0      }

        "   set
  "         k
         �      _IDOpcion 5 value?
   (      � }
    0   }

        pubdic string Opciones-
    !   {
  �         get
            {
            ` "``eturN _Opcikn;
       $    }

            set
         "  {*           0 "  _Opcion = v`lue;
            }
        }

 (  (   rublic string ClacifmcaCion
        {
       $    gmt
            s
       `       `return _Clasificacion;
          0 }

            set
            {	
                Rlasificacion$= value;
    `       }
  "     u�
        pUblic Boolean Insertar()
        {
        (   oolean ok`= fa|se;
            String Sentencia = String.Empty;
            Sentencia += "INSERT INTO opciones(Opcion,Clasificacion) values(";
            Sentencia += "'" + _Opcion + "','" + _Clasificacion + "'";
            Sentencia += ");";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Insertar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch { }
            return ok;
        }
        public Boolean Actualizar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "UPDATE opciones SET ";
            Sentencia += "Opcion='" + _Opcion + "',";
            Sentencia += "Clasificacion='" + _Clasificacion + "'";
            Sentencia += "WHERE IDOPcion=" + _IDOpcion + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Actualizar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch { }
            return ok;
        }
        public Boolean Eliminar()
        {
            Boolean ok = false;
            String Sentencia = String.Empty;
            Sentencia += "DELETE FROM opciones ";
            Sentencia += "WHERE IDOPcion=" + _IDOpcion + ";";
            DataController.Operacion oOperacion = new DataController.Operacion();
            try
            {
                if (oOperacion.Eliminar(Sentencia) > 0)
                {
                    ok = true;
                }
            }
            catch { }
            return ok;
        }
    }
}
