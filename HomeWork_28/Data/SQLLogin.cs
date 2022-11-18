using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.PostgresTypes;

namespace HomeWork_28.Data
{
    internal static class SqlLogin
    {
        private static string _loginPostgre = "postgres";
        private static string _passwordPostgre = "123";
        private static string _port = "5432";
        private static string _server="localhost";

        public static string LoginPostgre
        {
            get => $"UserId={_loginPostgre};";
            set => _loginPostgre = value;
        }

        public static string PasswordPostgre
        {
            get => $"Password={_passwordPostgre};";
            set => _passwordPostgre = value;
        }

        public static string Port
        {
            get => $"Port={_port};";
            set => _port = value;
        }

        public static string Server
        {
            get => $"Server={_server};";
            set => _server = value;
        }

        public static string GetConnectionString(string dataBase) =>
            $"{Server}{Port}{LoginPostgre}{PasswordPostgre}{dataBase};";

        //"Driver={PostgreSQL ODBC Driver(UNICODE)};
        //database=Clients_HW_28;
        //server=localhost;
        //port=5432;
        //uid=postgres;
        //sslmode=disable;
        //readonly=0;
        //protocol=7.4;
        //fakeoidindex=0;
        //showoidcolumn=0;
        //rowversioning=0;
        //showsystemtables=0;
        //fetch=100;
        //unknownsizes=0;
        //maxvarcharsize=255;
        //maxlongvarcharsize=8190;
        //debug=0;
        //commlog=0;
        //usedeclarefetch=0;
        //textaslongvarchar=1;
        //unknownsaslongvarchar=0;
        //boolsaschar=1;
        //parse=0;
        //lfconversion=1;
        //updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;xaopt=1"
    }
}
