using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return this.movies;
        }

        public void add(Movie movie)
        {
            movies.Add(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            IList<Movie> pixar_list = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.production_studio == ProductionStudio.Pixar)
                    pixar_list.Add(movie);
            }

            return pixar_list;
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            IList<Movie> pixar_disney_list = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.production_studio == ProductionStudio.Pixar ||
                    movie.production_studio == ProductionStudio.Disney)
                    pixar_disney_list.Add(movie);
            }

            return pixar_disney_list;
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            //IEnumerable<Movie> sorted_movies = new List<Movie>();
            //sorted_movies.
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            IList<Movie> not_pixar_list = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.production_studio != ProductionStudio.Pixar)
                    not_pixar_list.Add(movie);
            }

            return not_pixar_list;
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            IList<Movie> pub_date_list = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.date_published.Year > year)
                    pub_date_list.Add(movie);
            }

            return pub_date_list;
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            IList<Movie> pub_date_list = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
                    pub_date_list.Add(movie);
            }

            return pub_date_list;
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            IList<Movie> kid_movies = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.genre == Genre.kids)
                    kid_movies.Add(movie);
            }

            return kid_movies;
        }

        public IEnumerable<Movie> all_action_movies()
        {
            IList<Movie> action_movies = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie.genre == Genre.action)
                    action_movies.Add(movie);
            }

            return action_movies;
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}