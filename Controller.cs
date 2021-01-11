using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }


        public int InsertProject(string Pname, int pnumber, string Plocation, int Dnum)
        {
            string query = "INSERT INTO Project (Pname, Pnumber, Plocation, Dnum)" +
                            "Values ('" + Pname + "'," + pnumber + ",'" + Plocation + "'," + Dnum + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepNum()
        {
            string query= "SELECT Dnumber, Dname FROM Department;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepLoc()
        {
            string query = "SELECT DISTINCT Dlocation FROM Dept_Locations;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectProject(string location)
        {
            string query = "SELECT Pname,Dname FROM Department D, Project P, Dept_Locations L"
             +" where P.Dnum=D.Dnumber and L.Dnumber=D.Dnumber and L.Dlocation='"+location+"';"; 
            
            return dbMan.ExecuteReader(query);
        }
        //==============sign in ==================//

        public int signintype(string username,string pass)
        {
            string query = "Select Users.user_type from Users where username='"+username+"' and '"+pass+"'=(select Users.password from Users Where Users.username='"+username+"');";
            return (int)dbMan.ExecuteScalar(query);
        }
        //--------------------------SIGNUP---------------------------//
        public int InsertPerson(string Fname,string mini, string last, int net,string datestart,string dateborn,string nation,string sex)
        {
            string query = " INSERT INTO People(First_name, M_init, Last_name, Net_worth, career_start, DOB, nationality, sex)" +
                         "VALUES('" + Fname + "', '" + mini + "', '" + last + "', " + net + ", '" + datestart + "', '" + dateborn + "', '" + nation + "', '" + sex + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insertuser(int type,string username,string pass,string f,string m,string l,string dob)
        {
            string query="INSERT INTO Users(user_type, username, password, Person_ID) " +
             "VALUES("+type+", '"+username+"', '"+pass+"'," +
             "(select People.Person_ID from People where People.First_name = '"+f+"' and People.M_init = '"+m+"' and People.Last_name = '"+l+"' and People.DOB = '"+dob+"'));";
            return dbMan.ExecuteNonQuery(query);
        }
        //--------------------------addmoviesbyactor---------------------------//
        public int Insertmovie(string title, int dur, int bud, int box,string dist,string com,string Con,string lan,string rel)
        {
            string query = "INSERT INTO Movies(Title, Duration, Budget, Box_office, Dist_by, composer, Country, Language, Release_Date) " +
                          "VALUES('"+title+"', "+dur+", "+bud+", "+box+", '"+dist+"', '"+com+"', '"+Con+"', '"+lan+"', '"+rel+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int getmovieidfromtitle(string title)
        {
            string query = "Select Movies.Movie_ID from Movies where Movies.Title = '"+title+"'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int insertgenre(string title,string genre)
        {
            string query = "insert into genre(ID_movie, movie_type) values((Select Movies.Movie_ID from Movies where Movies.Title = '"+title+"'),'"+genre+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int linkstar(string username, string title,string fq)
        {
            string query = "insert into Movie_Stars(Star_ID, Movie_ID, famousquote) " +
                           "values((Select Users.Person_ID from Users Where username = '" + username + "')," +
                           "(Select Movies.Movie_ID from Movies where Movies.Title = '" + title + "')," +
                           "'" + fq + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int linkdirector(string username, string title)
        {
            string query = "insert into directed(Director_ID, Movie_ID) "+
                           "values((Select Users.Person_ID from Users Where username = '"+username+"'),"+
                           "(Select Movies.Movie_ID from Movies where Movies.Title = '"+title+"'));" ;
            return dbMan.ExecuteNonQuery(query);
        }
        public int addcompany(string name, string found)
        {
            string query = "insert into[prod.comp](Name, Founded_In) values('"+name+"', '"+found+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int linkcompany(string title, string cmp)
        {
            string query = "insert into prodBY(ID_movie, id_production) "+
                           "values((Select Movies.Movie_ID from Movies where Movies.Title = '"+title+"'),"+
                           "(Select[prod.comp].Com_ID from[prod.comp] Where[prod.comp].Name = '"+cmp+"'));" ;
            return dbMan.ExecuteNonQuery(query);
        }
        public int addhead(string name, string city)
        {
            string query = "insert into head(ID_comany, city) values((Select[prod.comp].Com_ID from[prod.comp] Where[prod.comp].Name = '"+name+"'),'"+city+"');" ;
            return dbMan.ExecuteNonQuery(query);
        }
        public int insertaward(string name)
        {
            string query = "insert into Awards(Award_name) values('"+name+"');" ;
            return dbMan.ExecuteNonQuery(query);
        }
        public int linkaward(string username,string award,int year)
        {
            string query = "insert into Awarded(ID_Award, ID_Person, Year) "+
                           "values( "+
                           "(select Awards.Award_ID from Awards where Awards.Award_name = '"+award+"'),"+
                           "(Select Users.Person_ID from Users Where username = '"+username+"'),"+year+");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int rateadd(string title, string username, int rate)
        {
            string query = " insert into ratings(ID_movie, User_ID, rate) "+
                           " values((Select Movies.Movie_ID from Movies where Movies.Title = '"+title+"'),"+
                            "(select Users.User_ID from Users Where username = '"+username+"'),"+rate+");" ;
            return dbMan.ExecuteNonQuery(query);
        }
        public int Updatemovie(string title,string rd,string dur,string lan,string distb,string bud,string box,string con,string oldT)
        {
            string query = "Update Movies Set Title = '"+title+"', Release_Date = '"+rd+"',Duration = '"+dur+"',Language = '"+lan+"',Dist_by = '"+distb+"',Budget = '"+bud+"',Box_office = '"+box+"',Country = '"+con+"' where Title = '"+oldT+"';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int changepass(string username,string password)
        {
            string query = "UPDATE Users SET password='' where username='';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int addcomp(string title ,string name)
        {
            string query = "Update Movies set composer='"+name+"' where Movies.Title='"+title+"';";
            return dbMan.ExecuteNonQuery(query);
        }
        //-----------------------------------INSERTIONS DONE-----------------------------------------------//

        //-----------------------------------public USER Queries-------------------------------------------//
        public DataTable selectnew5()
        {
            string query = "select TOP 5 Movies.Title , Movies.Release_Date from Movies Order by Movies.Release_Date DESC; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable selectnew()
        {
            string query = "Select AVG(ratings.rate) as avgRate,Movies.Title from ratings join Movies ON Movies.Movie_ID = ratings.ID_movie " +
                "where Movies.Title in (Select Title from Movies) " +
                 "Group BY Movies.Title " +
                   "order by avgRate DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable toprated()
        {
            string query = "select Movies.Title , Movies.Release_Date from Movies Order by Movies.Release_Date DESC; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable toprated5()
        {
            string query = "Select Top 5 AVG(ratings.rate) as avgRate,Movies.Title from ratings join Movies ON Movies.Movie_ID = ratings.ID_movie " +
                "where Movies.Title in (Select Title from Movies) "+
                 "Group BY Movies.Title "+
                   "order by avgRate DESC; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable lowrated5()
        {
            string query = "Select Top 5 AVG(ratings.rate) as avgRate,Movies.Title from ratings join Movies ON Movies.Movie_ID = ratings.ID_movie " +
                "where Movies.Title in (Select Title from Movies) " +
                 "Group BY Movies.Title " +
                   "order by avgRate ; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable topgross()
        {
            string query = "Select Movies.Title ,Movies.Box_office as Goss_in_M from Movies order By Box_office DESC; ";
            return dbMan.ExecuteReader(query);
        }
        // check the next two not sure about them
        public string randomquote()
        {
            string query = "select Top 1 Movie_Stars.famousquote from Movie_Stars order by NEWID(); ";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string movieq(string quote)
        {
            string query = "select Movies.Title from Movies join Movie_Stars ON Movies.Movie_ID = Movie_Stars.Movie_ID "+
                           "where Movie_Stars.famousquote = '"+quote+"' ";
            return (string)dbMan.ExecuteScalar(query);
        }
        public DataTable actorslist()
        {
            string query = "SELECT CONCAT(People.First_name, ' ', People.M_init, ' ', People.Last_name) as Person_name "+
                           "FROM People "+
                            "Join Users ON Users.Person_ID = People.Person_ID "+
                            "where user_type = 2; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable directorslist()
        {
            string query = "SELECT CONCAT(People.First_name, ' ', People.M_init, ' ', People.Last_name) as Person_name FROM People "+
                           "Join Users ON Users.Person_ID = People.Person_ID "+
                            "where user_type = 3; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable movieslist()
        {
            string query = "Select Movies.Title from Movies order by Title; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable genreofmovie(string title)
        {
            string query = "select genre.movie_type from genre join Movies on Movies.Movie_ID = genre.ID_movie where Movies.Title = '"+title+"'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getcomplist()
        {
            string query = "Select Distinct Movies.composer from Movies";
            return dbMan.ExecuteReader(query);
        }

        public DataTable producersofmovie(string title)
        {
            string query = " select [prod.comp].Name from [prod.comp] "+
                "join prodBY ON prodBY.id_production =[prod.comp].Com_ID "+
                 "join Movies ON Movies.Movie_ID = prodBY.ID_movie "+
                 "Where Movies.Title = '"+title+"'; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable moviedata(string title)
        {
            string query = "select* from movies where Movies.Title = '"+title+"'";
            return dbMan.ExecuteReader(query);
        }
        //=================public search
        public DataTable topratedgenre(string genre)
        {
            string query = "Select Top 5 AVG(ratings.rate) as avgRate,Movies.Title from ratings " +
                           "join Movies ON Movies.Movie_ID = ratings.ID_movie " +
                            "join genre on genre.ID_movie = Movies.Movie_ID " +
                            "where genre.movie_type = '"+genre+"' and " +
                              "Movies.Title in (Select Title from Movies) " +
                              "Group BY Movies.Title " +
                             "order by avgRate DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable distributioncomapny(string com)
        {
            string query = "select Movies.Title from Movies where Dist_by = '"+com+"'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable awardsofstar(string f,string m,string l)
        {
            string query = "select Awards.Award_name,Awarded.Year from Awards " +
                           "join Awarded ON Awarded.ID_Award = Awards.Award_ID " +
                           "join People On People.Person_ID = Awarded.ID_Person " +
                          " where people.Person_ID = " +
                          "(select People.Person_ID from People where People.First_name = '"+f+"' and People.M_init = '"+m+"' and People.Last_name = '"+l+"');";
            return dbMan.ExecuteReader(query);
        }
        public DataTable filmsofdirector(string f, string m, string l)
        {
            string query = "select Movies.title from Movies " +
                              "join directed ON Movies.Movie_ID = directed.Movie_ID " +
                              "join People ON directed.Director_ID = People.Person_ID " +
                              "where people.Person_ID = " +
                             "(select People.Person_ID from People where People.First_name = '" + f + "' and People.M_init = '" + m + "' and People.Last_name = '" + l +"')";
            return dbMan.ExecuteReader(query);
        }
        
        public string getcompsername(string title)
        {
            string query = "select Movies.composer from Movies where Movies.Title = '" + title + "'";
            return (string)dbMan.ExecuteScalar(query);
        }
        public DataTable filmsbycomposer(string name)
        {
            string query = "select Movies.Title from Movies where Movies.composer = '"+name+"'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable mytopratedmovies(string username)
        {
            string query =
                "Select  AVG(ratings.rate) as avgRate,Movies.Title from ratings " +
                "join Movies ON Movies.Movie_ID=ratings.ID_movie " +
                "join genre on genre.ID_movie= Movies.Movie_ID " +
                "where Movies.Title in " +
                "(Select Title from Movies " +
                "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                "join People on People.Person_ID=Movie_Stars.Star_ID " +
                "where Person_ID=(Select Users.Person_ID from Users Where username='" + username + "')) " +
                "Group BY Movies.Title " +
                "order by avgRate DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable myworstratedmovies(string username)
        {
            string query =
                "Select  AVG(ratings.rate) as avgRate,Movies.Title from ratings " +
                "join Movies ON Movies.Movie_ID=ratings.ID_movie " +
                "join genre on genre.ID_movie= Movies.Movie_ID " +
                "where Movies.Title in " +
                "(Select Title from Movies " +
                "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                "join People on People.Person_ID=Movie_Stars.Star_ID " +
                "where Person_ID=(Select Users.Person_ID from Users Where username='" + username + "')) " +
                "Group BY Movies.Title " +
                "order by avgRate;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable howmanyrated(string username)
        {
            string query =
                "select count(ratings.User_ID) as NO_of_people_rated_your_movies from ratings " +
                 "Where ratings.ID_movie in " +
                   "(Select Movies.Movie_ID from Movies " +
                     "join Movie_Stars ON Movie_Stars.Movie_ID = Movies.Movie_ID " +
                  "join People ON People.Person_ID=Movie_Stars.Star_ID " +
                    "Where People.Person_ID=(Select Users.Person_ID from Users Where Users.username='peterparker23')); ";
            return dbMan.ExecuteReader(query);
        }


        public DataTable mytopgross(string username)
        {
            string query =
                         "select Movies.Title,Movies.Box_office as gross_In_M from Movies " +
                         "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                         "join People ON People.Person_ID=Movie_Stars.Star_ID " +
                         "where Person_ID=(Select Users.Person_ID from Users Where username='"+username+"') " +
                         "Order BY Movies.Box_office DESC;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable mylowgross(string username)
        {
            string query =
                         "select TOP 5 Movies.Title,Movies.Box_office as gross_In_M from Movies " +
                         "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                         "join People ON People.Person_ID=Movie_Stars.Star_ID " +
                         "where Person_ID=(Select Users.Person_ID from Users Where username='" + username + "') " +
                         "Order BY Movies.Box_office;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable mytotalgross(string username)
        {
            string query =
                         "Select SUM(Movies.Box_office) as TOTAL_BOX_OFFICE_GROSS_IN_M from Movies " +
                          "Join Movie_Stars ON Movie_Stars.Movie_ID =Movies.Movie_ID " +
                          "Join People ON People.Person_ID = Movie_Stars.Star_ID " +
                          "where People.Person_ID = (Select Users.Person_ID from Users where Users.username='"+username+"');";
            return dbMan.ExecuteReader(query);
        }


        public int totalminacting(string username)
        {
            string query =
                         "select sum(Movies.Duration) as sum_min from Movies " +
                        "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                          "join People ON People.Person_ID=Movie_Stars.Star_ID " +
                          "where Person_ID=(Select Users.Person_ID from Users Where username='" + username + "');";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable myawards(string username)
        {
            string query =
                         "select Awards.Award_name,Awarded.Year from Awards " +
                         "join Awarded ON Awarded.ID_Award=Awards.Award_ID " +
                         "join People On People.Person_ID=Awarded.ID_Person " +
                         "where people.Person_ID=(Select Users.Person_ID from Users Where username='"+username+"');";
            return dbMan.ExecuteReader(query);
        }

                     
        public DataTable getawradsfromname(string f,string m, string l)
        {
            string query = "select Awards.Award_name,Awarded.Year from Awards " +
                         "join Awarded ON Awarded.ID_Award=Awards.Award_ID " +
                         "join People On People.Person_ID=Awarded.ID_Person " +
                         "where people.Person_ID=(Select People.Person_ID from People Where  People.First_name='" + f + "' and People.M_init='" + m + "' and People.Last_name='" + l + "');";


            return dbMan.ExecuteReader(query);
        }
        public DataTable mymovies(string username)
        {
            string query =
                         "Select Movies.Title,Movies.Box_office,Movies.composer,Movies.Budget,Movies.Country, " +
                         "Movies.Dist_by,Movies.Duration,Movies.Release_Date,Movies.Language from Movies " +
                         "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                         "join People ON People.Person_ID=Movie_Stars.Star_ID " +
                         "where people.Person_ID=(Select Users.Person_ID from Users Where username='"+username+"')";
            return dbMan.ExecuteReader(query);
        }
        public DataTable mymoviesdir(string username)
        {
            string query =
                         "Select Movies.Title,Movies.Box_office,Movies.composer,Movies.Budget,Movies.Country, " +
                        " Movies.Dist_by,Movies.Duration,Movies.Release_Date,Movies.Language from Movies  " +
                         "join directed ON directed.Director_ID=Movies.Movie_ID " +
                         "join People ON People.Person_ID=directed.Director_ID " +
                         "where people.Person_ID=(Select Users.Person_ID from Users Where username='" + username + "');";
            return dbMan.ExecuteReader(query);
        }
        public DataTable mymoviestitles(string username)
        {
            string query =
                         "Select Movies.Title from Movies " +
                         "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                         "join People ON People.Person_ID=Movie_Stars.Star_ID " +
                         "where people.Person_ID=(Select Users.Person_ID from Users Where username='" + username + "')";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getmoviesofdirector(string f,string m,string l)
        {
            string query =
                           "select Movies.Title from Movies " +
                        "join directed ON directed.Movie_ID=Movies.Movie_ID " +
                  "join People On directed.Director_ID=People.Person_ID " +
                 "where people.Person_ID=(Select People.Person_ID from People Where  People.First_name='" + f + "' and People.M_init='" + m + "' and People.Last_name='" + l + "');";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getmoviesofcomposer(string name)
        {
            string query = "Select Movies.Title from Movies Where Movies.composer = '"+name+"';";
            return dbMan.ExecuteReader(query);
        }



        public DataTable mydirectors(string username)
        {
            string query =
                           "select " +
                           "CONCAT(People.First_name,' ',People.M_init,' ',People.Last_name) as director_name " +
                           "from People " +
                           "join directed ON People.Person_ID=directed.Director_ID " +
                           "join Movies ON directed.Movie_ID=Movies.Movie_ID " +
                           "where Movies.Title in " +
                           "(Select Title from Movies " +
                           "join Movie_Stars ON Movie_Stars.Movie_ID=Movies.Movie_ID " +
                           "join People on People.Person_ID=Movie_Stars.Star_ID " +
                           "where Person_ID=(Select Users.Person_ID from Users Where username='"+username+"'));";
            return dbMan.ExecuteReader(query);
        }
        public DataTable mystars(string username)
        {
            string query =
                                                      "select " +
                           "CONCAT(People.First_name,' ',People.M_init,' ',People.Last_name) as star_name " +
                           "from People  " +
                           "join Movie_Stars ON Movie_Stars.Star_ID=People.Person_ID " +
                           "join Movies ON Movies.Movie_ID=Movie_Stars.Movie_ID " +
                           "where Movies.Title in " +
                           "(Select Title from Movies " +
                           "join directed ON directed.Movie_ID=Movies.Movie_ID " +
                           "join People on People.Person_ID=directed.Director_ID " +
                           "where Person_ID=(Select Users.Person_ID from Users Where username='" + username + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable genrelist()
        {
            string query = "Select Distinct genre.movie_type from genre;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable dislist()
        {
            string query = "Select Distinct [prod.comp].Name from [prod.comp]";
            return dbMan.ExecuteReader(query);
        }

        public DataTable moviefromdist(string dis)
        {
            string query = "Select Movies.Title from Movies Where Dist_by = '"+dis+"'; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable prodlist()
        {
            string query = "Select distinct [prod.comp].Name from [prod.comp]";
            return dbMan.ExecuteReader(query);
        }
        //===========================================ADMIN FUNCTIONS======================================//
        public DataTable Allmovies()
        {
            string query = "Select * From Movies";
            return dbMan.ExecuteReader(query);
        }
        public DataTable AllUsers()
        {
            string query = "Select * from Users";
            return dbMan.ExecuteReader(query);
        }
        public DataTable AllPeople()
        {
            string query = "Select * from People";
            return dbMan.ExecuteReader(query);
        }
        public DataTable AllProduction()
        {
            string query = "Select * from [prod.comp] Join head ON head.ID_comany=[prod.comp].Com_ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Allstars()
        {
            string query = "Select * from Movie_Stars Join People ON Movie_Stars.Star_ID= People.Person_ID join Movies ON Movies.Movie_ID=Movie_Stars.Movie_ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Alldirectors()
        {
            string query = "Select * from directed  Join People ON People.Person_ID=directed.Director_ID";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Allrating()
        {
            string query = "Select * from ratings Join Movies ON Movies.Movie_ID = ratings.ID_movie";
            return dbMan.ExecuteReader(query);
        }
        public int manyactors()
        {
            string query = "select COUNT(Users.User_ID) from Users Where user_type=2;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int manydirectors()
        {
            string query = "select COUNT(Users.User_ID) from Users Where user_type=3;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int manypublic()
        {
            string query = "select COUNT(Users.User_ID) from Users Where user_type=4;";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int countusers()
        {
            string query = "select COUNT(Users.User_ID) from Users ";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int totalrates()
        {
            string query = "Select Count(Distinct ratings.User_ID) from ratings";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int avgnet()
        {
            string query = "Select avg(People.Net_worth) from People";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable usersthatratedmost()
        {
            string query = "Select Top 5 Count(ratings.User_ID) as VOTES,People.First_name,People.M_init,People.Last_name from ratings join Users  on Users.Person_ID=ratings.User_ID join People on People.Person_ID= Users.Person_ID group by People.First_name,People.Last_name,People.M_init order by VOTES DESC";
            return dbMan.ExecuteReader(query);
        }
        public int Deleteuser(int userid)
        {
            string query = "Delete from Users Where Users.User_ID="+userid+";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable awardslist()
        {
            string query = "select Awards.Award_name from Awards";
            return dbMan.ExecuteReader(query);
        }
       
    }
}
