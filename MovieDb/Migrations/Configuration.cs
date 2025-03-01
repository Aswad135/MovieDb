using MovieDb.Models;
using System.Collections.Generic;



namespace MovieDb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieDb.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieDb.Models.ApplicationDbContext context)
        {

            if (!context.Genres.Any() && !context.Movies.Any() &&
                !context.Actors.Any() && !context.Appearances.Any())
            {

                AddGenres(context);
                addMovies(context);
                addActors(context);
                addAppearances(context);
            }




        }

      

        private void AddGenres(ApplicationDbContext context)
        {
            var genre = new List<Genre>
            {
                new Genre{Name="Action"},
                new Genre{Name="Adventure"},
                new Genre {Name="Comedy"},
                new Genre {Name="Crime"},
                new Genre {Name="Drama"},
                new Genre {Name="Fantasy"},
                new Genre {Name="Historical"},
                new Genre {Name="Historical Fiction"},
                new Genre {Name="Horror"},
                new Genre {Name="Magical realism"},
                new Genre {Name="Paranoid"},
                new Genre {Name="Philosophical"},
                new Genre {Name="Political"},
                new Genre {Name="Romance"},
                new Genre {Name="Satire"},
                new Genre {Name="Science Fiction"},
                new Genre {Name="Slice of life"},
                new Genre {Name="Speculative"},
                new Genre {Name="Thriller"},
                new Genre {Name="Urban"},
                new Genre {Name="Western"},
                new Genre {Name="Biography"},
                new Genre {Name="Family"},
                new Genre {Name="Music"},
                new Genre {Name="Mystery"},
                new Genre {Name="Sport"},
                new Genre {Name="War"},
                new Genre {Name="Documentary"}
                //new Genre {Name=""}
            };

            genre.ForEach(s => context.Genres.AddOrUpdate(s));
            context.SaveChanges();
        }

        //Movies: Title, ReleaseDate, Description, CoverPicture, GenreName
        private void addMovies(ApplicationDbContext context) {

            var movie = new List<Movie>
            {
               new Movie {
                    Title ="Logan",
                    ReleaseDate =DateTime.Parse("2017-03-03"),
                    Description ="In the near future, the aging Wolverine and Professor X must protect a young female clone of Wolverine from an evil organization led by Nathanial Essex. ",
                    CoverPicture ="/Content/Images/logan.jpg",
                    GenreName ="Science Fiction",
                    TrailerLink = "https://www.youtube.com/embed/Div0iP65aZo"
                    },
                new Movie {Title="District 9",
                    ReleaseDate =DateTime.Parse("2009-08-14"),
                    Description =" An extraterrestrial race forced to live in slum-like conditions on Earth suddenly finds a kindred spirit in a government agent who is exposed to their biotechnology. ",
                    CoverPicture ="/Content/Images/district9.jpg",
                    GenreName ="Science Fiction",
                    TrailerLink ="https://www.youtube.com/embed/DyLUwOcR5pk"},
                new Movie {
                Title="Taxi 3",
                ReleaseDate =DateTime.Parse("2003-02-27"),
                Description ="Out to stop a new gang disguised as Santa Claus, Emilien and Daniel must also handle major changes in their personal relationships. ",
                CoverPicture ="/Content/Images/taxi3.jpg",
                GenreName ="Action",
                TrailerLink = "https://www.youtube.com/embed/M2CG2LPic_E" },
                new Movie {
                Title="Jack Reacher: Never Go Back",
                ReleaseDate =DateTime.Parse("2016-10-21"),
                Description ="Jack Reacher must uncover the truth behind a major government conspiracy in order to clear his name. On the run as a fugitive from the law, Reacher uncovers a potential secret from his past that could change his life forever.",
                CoverPicture ="/Content/Images/jackRacher.jpg",
                GenreName ="Crime",
                TrailerLink = "https://www.youtube.com/embed/aRwrdbcAh2s"},
                new Movie {
                Title="Inferno",
                ReleaseDate =DateTime.Parse("2016-10-28"),
                Description =" When Robert Langdon wakes up in an Italian hospital with amnesia, he teams up with Dr. Sienna Brooks, and together they must race across Europe against the clock to foil a deadly global plot.",
                CoverPicture ="/Content/Images/inferno.jpg",
                GenreName ="Crime",
                TrailerLink ="https://www.youtube.com/embed/RH2BD49sEZI"},
                new Movie {
                Title="The Accountant",
                ReleaseDate =DateTime.Parse("2016-10-14"),
                Description =" As a math savant uncooks the books for a new client, the Treasury Department closes in on his activities and the body count starts to rise.",
                CoverPicture ="/Content/Images/accountant.jpg",
                GenreName ="Crime ",
                TrailerLink ="https://www.youtube.com/embed/DBfsgcswlYQ"},
                new Movie {
                Title="Doctor Strange",
                ReleaseDate =DateTime.Parse("2016-11-04"),
                Description =" A former neurosurgeon embarks on a journey of healing only to be drawn into the world of the mystic arts.",
                CoverPicture ="/Content/Images/doctorStrange.jpg",
                GenreName ="Science Fiction",
                TrailerLink ="https://www.youtube.com/embed/HSzx-zryEgM"},
                new Movie {
                Title="Guardians of the Galaxy Vol. 2",
                ReleaseDate =DateTime.Parse("2017-05-05"),
                Description =" Set to the backdrop of Awesome Mixtape #2, 'Guardians of the Galaxy Vol. 2' continues the team's adventures as they unravel the mystery of Peter Quill's true parentage.",
                CoverPicture ="/Content/Images/guardians2.jpg",
                GenreName ="Science Fiction",
                TrailerLink ="https://www.youtube.com/embed/wX0aiMVvnvg" },
                new Movie {
                Title="Power Rangers",
                ReleaseDate =DateTime.Parse("2017-03-24"),
                Description =" A group of high-school kids, who are infused with unique superpowers, harness their abilities in order to save the world.",
                CoverPicture ="/Content/Images/powerRangers.jpg",
                GenreName ="Science Fiction",
                TrailerLink ="https://www.youtube.com/embed/Q-C4qqsgs8w"},
                new Movie {
                Title="Hacksaw Ridge",
                ReleaseDate =DateTime.Parse("2016-10-24"),
                Description =" WWII American Army Medic Desmond T. Doss, who served during the Battle of Okinawa, refuses to kill people and becomes the first Conscientious Objector in American history to be awarded the Medal of Honor.",
                CoverPicture ="/Content/Images/hacksaw.jpg",
                GenreName ="Biography",
                TrailerLink ="https://www.youtube.com/embed/s2-1hz1juBI"},
                new Movie {
                Title="The Infiltrator",
                ReleaseDate =DateTime.Parse("2016-07-06"),
                Description ="A U.S. Customs official uncovers a money laundering scheme involving Colombian drug lord Pablo Escobar.",
                CoverPicture ="/Content/Images/infiltrator.jpg",
                GenreName ="Biography",
                TrailerLink ="https://www.youtube.com/embed/N7_M4hjXW1I" },
                new Movie {
                Title="Neruda",
                ReleaseDate =DateTime.Parse("2016-09-04"),
                Description ="An inspector hunts down Nobel Prize-winning Chilean poet, Pablo Neruda, who becomes a fugitive in his home country in the late 1940s for joining the Communist Party.",
                CoverPicture ="/Content/Images/neruda.jpg",
                GenreName ="Biography",
                TrailerLink ="https://www.youtube.com/embed/neUwXV_cSwM"},
                new Movie {
                Title="Snowden",
                ReleaseDate =DateTime.Parse("2016-07-21"),
                Description =" The NSA's illegal surveillance techniques are leaked to the public by one of the agency's employees, Edward Snowden, in the form of thousands of classified documents distributed to the press.",
                CoverPicture ="/Content/Images/snowden.jpg",
                GenreName ="Biography",
                TrailerLink ="https://www.youtube.com/embed/QlSAiI3xMh4"},
                new Movie {
                Title="Me Before You",
                ReleaseDate =DateTime.Parse("2016-06-03"),
                Description ="A girl in a small town forms an unlikely bond with a recently-paralyzed man she's taking care of.",
                CoverPicture ="/Content/Images/mebeforeu.jpg",
                GenreName ="Romance",
                TrailerLink ="https://www.youtube.com/embed/Eh993__rOxA"},
                new Movie {
                Title="Bridget Jones's Baby",
                ReleaseDate =DateTime.Parse("2016-09-16"),
                Description ="Bridget's focus on single life and her career is interrupted when she finds herself pregnant, but with one hitch ... she can only be fifty percent sure of the identity of her baby's father.",
                CoverPicture ="/Content/Images/bridgetJones.jpg",
                GenreName ="Romance",
                TrailerLink ="https://www.youtube.com/embed/zQkOY5H5d2g"},
                new Movie {
                Title="Beauty and the Beast",
                ReleaseDate =DateTime.Parse("2017-03-17"),
                Description ="An adaptation of the classic fairy-tale about a monstrous prince and a young woman who fall in love.",
                CoverPicture ="/Content/Images/beauty&beast.jpg",
                GenreName ="Romance",
                TrailerLink ="https://www.youtube.com/embed/OvW_L8sTu5E"},
                new Movie {
                Title="Titanic",
                ReleaseDate =DateTime.Parse("1997-12-19"),
                Description ="A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                CoverPicture ="/Content/Images/titanic.jpg",
                GenreName ="Romance",
                TrailerLink ="https://www.youtube.com/embed/2e-eXJ6HgkQ"},
                new Movie {
                Title="Hocus Pocus",
                ReleaseDate =DateTime.Parse("1993-07-16"),
                Description ="After three centuries, three witch sisters are resurrected in Salem, Massachusetts on Halloween night, and it is up to two teenagers, a young girl, and an immortal cat to put an end to their reign of terror once and for all.",
                CoverPicture ="/Content/Images/hocus.jpg",
                GenreName ="Family",
                TrailerLink ="https://www.youtube.com/embed/2UUMsInka2s" },
                new Movie {
                Title="Maleficent",
                ReleaseDate =DateTime.Parse("2014-05-30"),
                Description ="A vengeful fairy is driven to curse an infant princess, only to discover that the child may be the one person who can restore peace to their troubled land.",
                CoverPicture ="/Content/Images/maleficent.jpg",
                GenreName ="Family",
                TrailerLink ="https://www.youtube.com/embed/_pgmFAOgm5E"},
                new Movie {
                Title="Nine Lives",
                ReleaseDate =DateTime.Parse("2016-08-05"),
                Description ="A stuffy businessman finds himself trapped inside the body of his family's cat.",
                CoverPicture ="/Content/Images/nineLives.jpg",
                GenreName ="Family",
                TrailerLink ="https://www.youtube.com/embed/_jHA97HzhxE"},
                new Movie {
                Title="Westworld",
                ReleaseDate =DateTime.Parse("1973-11-21"),
                Description ="In 1983, a robot malfunction creates havoc and terror for unsuspecting vacationers at a futuristic, adult-themed amusement park.",
                CoverPicture ="/Content/Images/westworld.jpg",
                GenreName ="Western",
                TrailerLink ="https://www.youtube.com/embed/LcL3eP0Hfy4"},
                new Movie {
                Title="The Magnificent Seven",
                ReleaseDate =DateTime.Parse("2016-09-23"),
                Description ="Seven gun men in the old west gradually come together to help a poor village against savage thieves.",
                CoverPicture ="/Content/Images/magnificentSeven.jpg",
                GenreName ="Western",
                TrailerLink ="https://www.youtube.com/embed/q-RBA0xoaWU" },
                new Movie {
                Title="The Hateful Eight",
                ReleaseDate =DateTime.Parse("2015-12-25"),
                Description ="In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.",
                CoverPicture ="/Content/Images/hateful8.jpg",
                GenreName ="Western",
                TrailerLink ="https://www.youtube.com/embed/nIOmotayDMY"},
                new Movie {
                Title="Django Unchained",
                ReleaseDate =DateTime.Parse("2012-12-28"),
                Description ="With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
                CoverPicture ="/Content/Images/django.jpg",
                GenreName ="Western",
                TrailerLink ="https://www.youtube.com/embed/eUdM9vrCbow"},
                new Movie {
                Title="Suicide Squad",
                ReleaseDate =DateTime.Parse("2016-08-01"),
                Description ="A secret government agency recruits some of the most dangerous incarcerated super-villains to form a defensive task force. Their first mission: save the world from the apocalypse.",
                CoverPicture ="/Content/Images/suicideSquad.jpg",
                GenreName ="Action",
                TrailerLink ="https://www.youtube.com/embed/CmRih_VtVAs"},
                new Movie {
                Title="Independence Day: Resurgence",
                ReleaseDate =DateTime.Parse("2016-06-24"),
                Description ="Two decades after the first Independence Day invasion, Earth is faced with a new extra-Solar threat. But will mankind's new space defenses be enough?",
                CoverPicture ="/Content/Images/independenceDay.jpg",
                GenreName ="Action",
                TrailerLink ="https://www.youtube.com/embed/R7a2u8lxWm8"},
                new Movie {
                Title="X-Men: Apocalypse",
                ReleaseDate =DateTime.Parse("2016-05-27"),
                Description ="After the re-emergence of the world's first mutant, world-destroyer Apocalypse, the X-Men must unite to defeat his extinction level plan.",
                CoverPicture ="/Content/Images/xmenApocalypse.jpg",
                GenreName ="Action",
                TrailerLink ="https://www.youtube.com/embed/Jer8XjMrUB4"},
                new Movie {
                Title="Resident Evil: The Final Chapter",
                ReleaseDate =DateTime.Parse("2017-01-27"),
                Description ="Picking up immediately after the events in Resident Evil: Retribution, humanity is on its last legs in Washington D.C. As the only survivor of what was meant to be humanity's final stand against the undead hordes, Alice must return to where the nightmare began - Raccoon City, where the Umbrella Corporation is gathering its forces for a final strike against the only remaining survivors of the apocalypse��",
                CoverPicture ="/Content/Images/residentEvil.jpg",
                GenreName ="Action",
                TrailerLink ="https://www.youtube.com/embed/8gQIL8uV_Tc"},
                new Movie {
                Title="Fantastic Beasts and Where to Find Them",
                ReleaseDate =DateTime.Parse("2016-11-18"),
                Description ="The adventures of writer Newt Scamander in New York's secret community of witches and wizards seventy years before Harry Potter reads his book in school.",
                CoverPicture ="/Content/Images/fantasticBeasts.jpg",
                GenreName ="Adventure",
                TrailerLink ="https://www.youtube.com/embed/Vso5o11LuGU" },
                new Movie {
                Title="Miss Peregrine's Home for Peculiar Children",
                ReleaseDate =DateTime.Parse("2016-09-30"),
                Description ="When Jacob discovers clues to a mystery that stretches across time, he finds Miss Peregrine's Home for Peculiar Children. But the danger deepens after he gets to know the residents and learns about their special powers.",
                CoverPicture ="/Content/Images/missPeregrine.jpg",
                GenreName ="Adventure",
                TrailerLink ="https://www.youtube.com/embed/tV_IhWE4LP0" },
                new Movie {
                Title="Ghostbusters",
                ReleaseDate =DateTime.Parse("1984-06-08"),
                Description ="Three former parapsychology professors set up shop as a unique ghost removal service.",
                CoverPicture ="/Content/Images/ghostbusters.jpg",
                GenreName ="Adventure",
                TrailerLink ="https://www.youtube.com/embed/vntAEVjPBzQ"},
                new Movie {
                Title="Alice Through the Looking Glass",
                ReleaseDate =DateTime.Parse("2016-05-27"),
                Description ="Alice returns to the whimsical world of Wonderland and travels back in time to help the Mad Hatter.",
                CoverPicture ="/Content/Images/aliceGlass.jpg",
                GenreName ="Adventure",
                TrailerLink ="https://www.youtube.com/embed/ynt9lWQG8uQ"},
                new Movie {
                Title="Bad Moms",
                ReleaseDate =DateTime.Parse("2016-07-29"),
                Description ="When three overworked and under-appreciated moms are pushed beyond their limits, they ditch their conventional responsibilities for a jolt of long overdue freedom, fun, and comedic self-indulgence.",
                CoverPicture ="/Content/Images/badMoms.jpg",
                GenreName ="Comedy",
                TrailerLink ="https://www.youtube.com/embed/iKCw-kqo3cs" },
                new Movie {
                Title="Everybody Wants Some!!",
                ReleaseDate =DateTime.Parse("2016-04-01"),
                Description ="A group of college baseball players navigate their way through the freedoms and responsibilities of unsupervised adulthood.",
                CoverPicture ="/Content/Images/everybodyWantaSome.jpg",
                GenreName ="Comedy",
                TrailerLink ="https://www.youtube.com/embed/komFgqFKR6o"},
                new Movie {
                Title="Mean Girls",
                ReleaseDate =DateTime.Parse("2004-04-30"),
                Description ="Cady Heron is a hit with The Plastics, the A-list girl clique at her new school, until she makes the mistake of falling for Aaron Samuels, the ex-boyfriend of alpha Plastic Regina George.",
                CoverPicture ="/Content/Images/meanGirls.jpg",
                GenreName ="Comedy",
                TrailerLink ="https://www.youtube.com/embed/KAOmTMCtGkI"},
                new Movie {
                Title="American Pie",
                ReleaseDate =DateTime.Parse("1999-07-09"),
                Description ="Four teenage boys enter a pact to lose their virginity by prom night.",
                CoverPicture ="/Content/Images/americanPie.jpg",
                GenreName ="Comedy",
                TrailerLink = "https://www.youtube.com/embed/iUZ3Yxok6N8" },
                new Movie {
                Title="The Shining",
                ReleaseDate =DateTime.Parse("1980-06-13"),
                Description ="A family heads to an isolated hotel for the winter where an evil and spiritual presence influences the father into violence, while his psychic son sees horrific forebodings from the past and of the future.",
                CoverPicture ="/Content/Images/shining.jpg",
                GenreName ="Horror",
                TrailerLink ="https://www.youtube.com/embed/iUZ3Yxok6N8"},
                new Movie {
                Title="Don't Breathe",
                ReleaseDate =DateTime.Parse("2016-08-26"),
                Description ="Hoping to walk away with a massive fortune, a trio of thieves break into the house of a blind man who isn't as helpless as he seems.",
                CoverPicture ="/Content/Images/dontBreathe.jpg",
                GenreName ="Horror",
                TrailerLink ="https://www.youtube.com/embed/76yBTNDB6vU"},
                new Movie {
                Title="A Nightmare on Elm Street",
                ReleaseDate =DateTime.Parse("1984-11-09"),
                Description ="Several people are hunted by a cruel serial killer who kills his victims in their dreams. While the survivors are trying to find the reason for being chosen, the murderer won't lose any chance to kill them as soon as they fall asleep.",
                CoverPicture ="/Content/Images/nightmareElm.jpg",
                GenreName ="Horror",
                TrailerLink ="https://www.youtube.com/embed/dCVh4lBfW-c"},
                new Movie {
                Title="The Conjuring",
                ReleaseDate =DateTime.Parse("2013-07-19"),
                Description ="Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse.",
                CoverPicture ="/Content/Images/conjuring.jpg",
                GenreName ="Horror",
                TrailerLink ="https://www.youtube.com/embed/Vjk2So3KvSQ"}

                /*  new Movie {
                Title="",
                ReleaseDate =DateTime.Parse(""),
                Description ="",
                CoverPicture ="/Context/Images/",
                GenreName =""}  */
            };

            movie.ForEach(s => context.Movies.AddOrUpdate(s));
            context.SaveChanges();
        }

        //Actors: Name
        private void addActors(ApplicationDbContext context)
        {

            var actor = new List<Actor>
            {
                //Logan
                new Actor {Name="Hugh Jackman"},
                new Actor {Name="Boyd Holbrook"},
                new Actor {Name="Doris Morgado"},
                new Actor {Name="Patrick Steward"},
                new Actor {Name="Elizabeth Rodriguez"},
                new Actor {Name="Stephen Merchant"},
                new Actor {Name="Richard E. Grant"},
                new Actor {Name="Dave Davis"},
                new Actor {Name="Julia Holt"},
                new Actor {Name="Juan Gaspard"},
                //District 9
                new Actor {Name="Sharlto Copley"},
                new Actor {Name="Jason Cope"},
                new Actor {Name="Nathalie Boltt"},
                new Actor {Name="John Summer"},
                //Taxi 3
                new Actor {Name="Samy Naceri"},
                new Actor {Name="Fr�d�ric Diefenthal"},
                new Actor {Name="Bernard Farcy"},
                new Actor {Name="Bai Ling"},
                new Actor {Name="Marion Cotillard"},
                new Actor {Name="Jean-Christophe Bouvet"},
                //Other....
                new Actor {Name="Tom Cruise"},
                new Actor {Name="Cobie Smulders"},
                new Actor {Name="Aldis Hodge"},
                new Actor {Name="Danika Yarosh"},
                new Actor {Name="Tom Hanks"},
                new Actor {Name="Felicity Jones"},
                new Actor {Name="Omar Sy"},
                new Actor {Name="Irrfan Khan"},
                new Actor {Name="Ben Affleck"},
                new Actor {Name="Anna Kendrick"},
                new Actor {Name="J.K. Simmons"},
                new Actor {Name="Jon Bernthal"},
                new Actor {Name="Benedict Cumberbatch"},
                new Actor {Name="Chiwetel Ejiofor"},
                new Actor {Name="Rachel McAdams"},
                new Actor {Name="Benedict Wong"},
                new Actor {Name="Karen Gillan"},
                new Actor {Name="Chris Pratt"},
                new Actor {Name="Zoe Saldana"},
                new Actor {Name="Chris Sullivan"},
                new Actor {Name="Dacre Montgomery"},
                new Actor {Name="Bryan Cranston"},
                new Actor {Name="Elizabeth Banks"},
                new Actor {Name="Sarah Grey"},
                new Actor {Name="Teresa Palmer"},
                new Actor {Name="Andrew Garfield"},
                new Actor {Name="Sam Worthington"},
                new Actor {Name="Vince Vaughn"},
                new Actor {Name="Bryan Cranston"},
                new Actor {Name="Leanne Best"},
                new Actor {Name="Daniel Mays"},
                new Actor {Name="Tom Vaughan-Lawlor"},
                new Actor {Name="Gael Garc�a Bernal"},
                new Actor {Name="Luis Gnecco"},
                new Actor {Name="Mercedes Mor�n"},
                new Actor {Name="Alfredo Castro"},
                new Actor {Name="Melissa Leo"},
                new Actor {Name="Zachary Quinto"},
                new Actor {Name="Joseph Gordon-Levitt"},
                new Actor {Name="Jaymes Butler"},
                new Actor {Name="Sam Claflin"},
                new Actor {Name="Vanessa Kirby"},
                new Actor {Name="Emilia Clarke"},
                new Actor {Name="Eileen Dunwoodie"},
                new Actor {Name="Ren�e Zellweger"},
                new Actor {Name="Gemma Jones"},
                new Actor {Name="Jim Broadbent"},
                new Actor {Name="Sally Phillips"},
                new Actor {Name="Gugu Mbatha-Raw"},
                new Actor {Name="Emma Watson"},
                new Actor {Name="Luke Evans"},
                new Actor {Name="Ewan McGregor"},
                new Actor {Name="Dan Stevens"},
                new Actor {Name="Leonardo DiCaprio"},
                new Actor {Name="Kate Winslet"},
                new Actor {Name="Billy Zane"},
                new Actor {Name="Kathy Bates"},
                new Actor {Name="Bette Midler"},
                new Actor {Name="Sarah Jessica Parker"},
                new Actor {Name="Kathy Najimy"},
                new Actor {Name="Omri Katz"},
                new Actor {Name="Thora Birch"},
                new Actor {Name="Vinessa Shaw"},
                new Actor {Name="Angelina Jolie"},
                new Actor {Name="Elle Fanning"},
                new Actor {Name="Lesley Manville"},
                new Actor {Name="Kevin Spacey"},
                new Actor {Name="Jennifer Garner"},
                new Actor {Name="Robbie Amell"},
                new Actor {Name="Cheryl Hines"},
                new Actor {Name="Yul Brynner"},
                new Actor {Name="Richard Benjamin"},
                new Actor {Name="James Brolin"},
                new Actor {Name="Norman Bartold"},
                new Actor {Name="Denzel Washington"},
                new Actor {Name="Chris Pratt"},
                new Actor {Name="Ethan Hawke"},
                new Actor {Name="Vincent D'Onofrio"},
                new Actor {Name="Byung-hun Lee"},
                new Actor {Name="Manuel Garcia-Rulfo"},
                new Actor {Name="Martin Sensmeier"},
                new Actor {Name="Samuel L. Jackson"},
                new Actor {Name="Kurt Russell"},
                new Actor {Name="Jennifer Jason Leigh"},
                new Actor {Name="Walton Goggins"},
                new Actor {Name="Jamie Foxx"},
                new Actor {Name="Christoph Waltz"},
                new Actor {Name="Leonardo DiCaprio"},
                new Actor {Name="Kerry Washington"},
                new Actor {Name="Will Smith"},
                new Actor {Name="Jaime FitzSimons"},
                new Actor {Name="Ike Barinholtz"},
                new Actor {Name="Margot Robbie"},
                new Actor {Name="James McAvoy"},
                new Actor {Name="Michael Fassbender"},
                new Actor {Name="Jennifer Lawrence"},
                new Actor {Name="Nicholas Hoult"},
                new Actor {Name="Liam Hemsworth"},
                new Actor {Name="Jeff Goldblum"},
                new Actor {Name="Jessie T. Usher"},
                new Actor {Name="Bill Pullman"},
                new Actor {Name="Ali Larter"},
                new Actor {Name="Milla Jovovich"},
                new Actor {Name="Ruby Rose"},
                new Actor {Name="William Levy"},
                new Actor {Name="Eddie Redmayne"},
                new Actor {Name="Ezra Miller"},
                new Actor {Name="Colin Farrell"},
                new Actor {Name="Gemma Chan"},
                new Actor {Name="Eva Green"},
                new Actor {Name="Asa Butterfield"},
                new Actor {Name="Samuel L. Jackson"},
                new Actor {Name="Judi Dench"},
                new Actor {Name="Bill Murray"},
                new Actor {Name="Dan Aykroyd"},
                new Actor {Name="Sigourney Weaver"},
                new Actor {Name="Harold Ramis"},
                new Actor {Name="Johnny Depp"},
                new Actor {Name="Mia Wasikowska"},
                new Actor {Name="Helena Bonham Carter"},
                new Actor {Name="Anne Hathaway"},
                new Actor {Name="Mila Kunis"},
                new Actor {Name="Kathryn Hahn"},
                new Actor {Name="Kristen Bell"},
                new Actor {Name="Christina Applegate"},
                new Actor {Name="Lindsay Lohan"},
                new Actor {Name="Rachel McAdams"},
                new Actor {Name="Tina Fey"},
                new Actor {Name="Tim Meadows"},
                new Actor {Name="Blake Jenner"},
                new Actor {Name="Juston Street"},
                new Actor {Name="Ryan Guzman"},
                new Actor {Name="Tyler Hoechlin"},
                new Actor {Name="Jason Biggs"},
                new Actor {Name="Chris Klein"},
                new Actor {Name="Thomas Ian Nicholas"},
                new Actor {Name="Alyson Hannigan"},
                new Actor {Name="Jack Nicholson"},
                new Actor {Name="Shelley Duvall"},
                new Actor {Name="Danny Lloyd"},
                new Actor {Name="Scatman Crothers"},
                new Actor {Name="Stephen Lang"},
                new Actor {Name="Jane Levy"},
                new Actor {Name="Dylan Minnette"},
                new Actor {Name="Daniel Zovatto"},
                new Actor {Name="John Saxon"},
                new Actor {Name="Ronee Blakley"},
                new Actor {Name="Heather Langenkamp"},
                new Actor {Name="Amanda Wyss"},
                new Actor {Name="Johnny Depp"},
                new Actor {Name="Vera Farmiga"},
                new Actor {Name="Patrick Wilson"},
                new Actor {Name="Lily Taylor"},
                new Actor {Name="Ron Livingston"},



            };

            actor.ForEach(s => context.Actors.AddOrUpdate(s));
            context.SaveChanges();

        }

        //Apearances: MovieID, ActorID
        private void addAppearances(ApplicationDbContext context)
        {
            
            //Logan
            {
                var movie = context.Movies.First(a => a.Title == "Logan");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Hugh Jackman")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Boyd Holbrook")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Doris Morgado")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Patrick Steward")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Elizabeth Rodriguez")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Stephen Merchant")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Richard E. Grant")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Dave Davis")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Julia Holt")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Juan Gaspard")).ID
                    });
                context.SaveChanges();
            }
            //District 9
            {
                 var movie = context.Movies.First(a => a.Title == "District 9");
                 context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Sharlto Copley")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Jason Cope")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Nathalie Boltt")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "John Summer")).ID
                    }
                    );
                    context.SaveChanges();
            }
            //Taxi 3
            {
                var movie = context.Movies.First(a => a.Title == "Taxi 3");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Samy Naceri")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Fr�d�ric Diefenthal")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Bernard Farcy")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Bai Ling")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Marion Cotillard")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Jean-Christophe Bouvet")).ID
                    });
                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Jack Reacher: Never Go Back");
                        context.Appearances.AddOrUpdate(t => t.Movie,
                            new Appearance
                            {
				                MovieId = movie.ID,
				                ActorId = (context.Actors.First(b => b.Name == "Tom Cruise")).ID
			                },
                  new Appearance
                            {
				                MovieId = movie.ID,
				                ActorId = (context.Actors.First(b => b.Name == "Cobie Smulders")).ID
			                },
                  new Appearance
                            {
				                MovieId = movie.ID,
				                ActorId = (context.Actors.First(b => b.Name == "Aldis Hodge")).ID
			                },		
			                new Appearance
			                {
				                MovieId = movie.ID,
				                ActorId = (context.Actors.First(b => b.Name == "Danika Yarosh")).ID
			                });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Inferno");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Tom Hanks")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Felicity Jones")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Omar Sy")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Irrfan Khan")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "The Accountant");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Ben Affleck")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Anna Kendrick")).ID
                    },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "J.K. Simmons")).ID
                    },

                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Jon Bernthal")).ID
                    });

                context.SaveChanges();
            }

         

            {
                var movie = context.Movies.First(a => a.Title == "Doctor Strange");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Benedict Cumberbatch")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Chiwetel Ejiofor")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Rachel McAdams")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Benedict Wong")).ID
                    });

                context.SaveChanges();
            }

           

            {
                var movie = context.Movies.First(a => a.Title == "Guardians of the Galaxy Vol. 2");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Karen Gillan")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Chris Pratt")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Zoe Saldana")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Chris Sullivan")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Power Rangers");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Dacre Montgomery")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Bryan Cranston")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Elizabeth Banks")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Sarah Grey")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Hacksaw Ridge");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Teresa Palmer")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Andrew Garfield")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Sam Worthington")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Vince Vaughn")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "The Infiltrator");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Bryan Cranston")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Leanne Best")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Daniel Mays")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Tom Vaughan-Lawlor")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Neruda");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Gael Garc�a Bernal")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Luis Gnecco")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Mercedes Mor�n")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Alfredo Castro")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Snowden");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Melissa Leo")).ID
                    },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Zachary Quinto")).ID
        },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Joseph Gordon-Levitt")).ID
        },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Jaymes Butler")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Me Before You");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Sam Claflin")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Vanessa Kirby")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Emilia Clarke")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Eileen Dunwoodie")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Beauty and the Beast");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Gugu Mbatha-Raw")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Emma Watson")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Luke Evans")).ID
          },
                      new Appearance
                      {
                          MovieId = movie.ID,
                          ActorId = (context.Actors.First(b => b.Name == "Ewan McGregor")).ID
                      },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Dan Stevens")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Titanic");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Leonardo DiCaprio")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Kate Winslet")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Billy Zane")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Kathy Bates")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Hocus Pocus");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Bette Midler")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Sarah Jessica Parker")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Kathy Najimy")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Omri Katz")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Thora Birch")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Vinessa Shaw")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Maleficent");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Angelina Jolie")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Elle Fanning")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Sharlto Copley")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Lesley Manville")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Nine Lives");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Kevin Spacey")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jennifer Garner")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Robbie Amell")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Cheryl Hines")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Westworld");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Yul Brynner")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Richard Benjamin")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "James Brolin")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Norman Bartold")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "The Magnificent Seven");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Denzel Washington")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Chris Pratt")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Ethan Hawke")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Vincent D'Onofrio")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Byung-hun Lee")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Manuel Garcia-Rulfo")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Martin Sensmeier")).ID
                    });


                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "The Hateful Eight");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Samuel L. Jackson")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Kurt Russell")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jennifer Jason Leigh")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Walton Goggins")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Django Unchained");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Jamie Foxx")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Christoph Waltz")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Leonardo DiCaprio")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Kerry Washington")).ID
                    });


                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Suicide Squad");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Will Smith")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jaime FitzSimons")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Ike Barinholtz")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Margot Robbie")).ID
                    });


                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "X-Men: Apocalypse");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "James McAvoy")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Michael Fassbender")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jennifer Lawrence")).ID
          },
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Nicholas Hoult")).ID
                    });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Independence Day: Resurgence");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Liam Hemsworth")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jeff Goldblum")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jessie T. Usher")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Bill Pullman")).ID
         });

                context.SaveChanges();
            }


            {
                 var movie = context.Movies.First(a => a.Title == "Resident Evil: The Final Chapter");
                        context.Appearances.AddOrUpdate(t => t.Movie,
                            new Appearance
                            {
                                MovieId = movie.ID,
                                ActorId = (context.Actors.First(b => b.Name == "Ali Larter")).ID
                            },
                  new Appearance
                  {
                      MovieId = movie.ID,
                      ActorId = (context.Actors.First(b => b.Name == "Milla Jovovich")).ID
                  },
                  new Appearance
                  {
                      MovieId = movie.ID,
                      ActorId = (context.Actors.First(b => b.Name == "Ruby Rose")).ID
                  },
                 new Appearance
                 {
                     MovieId = movie.ID,
                     ActorId = (context.Actors.First(b => b.Name == "William Levy")).ID
                 });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Fantastic Beasts and Where to Find Them");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Eddie Redmayne")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Ezra Miller")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Colin Farrell")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Gemma Chan")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Miss Peregrine's Home for Peculiar Children");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Eva Green")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Asa Butterfield")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Samuel L. Jackson")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Judi Dench")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Ghostbusters");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Bill Murray")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Dan Aykroyd")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Sigourney Weaver")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Harold Ramis")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Alice Through the Looking Glass");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Johnny Depp")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Mia Wasikowska")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Helena Bonham Carter")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Anne Hathaway")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Bad Moms");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Mila Kunis")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Kathryn Hahn")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Kristen Bell")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Christina Applegate")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Mean Girls");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Lindsay Lohan")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Rachel McAdams")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Tina Fey")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Tim Meadows")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Everybody Wants Some!!");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Blake Jenner")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Juston Street")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Ryan Guzman")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Tyler Hoechlin")).ID
         });


                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "The Shining");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Jack Nicholson")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Shelley Duvall")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Danny Lloyd")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Scatman Crothers")).ID
         });

                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "Don't Breathe");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Stephen Lang")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Jane Levy")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Dylan Minnette")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Daniel Zovatto")).ID
         });


                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "A Nightmare on Elm Street ");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "John Saxon")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Ronee Blakley")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Heather Langenkamp")).ID
          },
        new Appearance
        {
            MovieId = movie.ID,
            ActorId = (context.Actors.First(b => b.Name == "Amanda Wyss")).ID
        },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Johnny Depp")).ID
         });


                context.SaveChanges();
            }

            {
                var movie = context.Movies.First(a => a.Title == "The Conjuring");
                context.Appearances.AddOrUpdate(t => t.Movie,
                    new Appearance
                    {
                        MovieId = movie.ID,
                        ActorId = (context.Actors.First(b => b.Name == "Vera Farmiga")).ID
                    },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Patrick Wilson")).ID
          },
          new Appearance
          {
              MovieId = movie.ID,
              ActorId = (context.Actors.First(b => b.Name == "Lily Taylor")).ID
          },
         new Appearance
         {
             MovieId = movie.ID,
             ActorId = (context.Actors.First(b => b.Name == "Ron Livingston")).ID
         });

                context.SaveChanges();
            }


            /*            
            {
            var movie = context.Movies.First(a => a.Title == "");
            context.Appearances.AddOrUpdate(t => t.Movie,
                new Appearance
                {
                    MovieId = movie.ID,
                    ActorId = (context.Actors.First(b => b.Name == "")).ID
                },
                new Appearance
                {
                    MovieId = movie.ID,
                    ActorId = (context.Actors.First(b => b.Name == "")).ID
                }
                );
                context.SaveChanges();
             }
            */


        }
        //Ratings

        //Comments

        //Favorites


    }
}


