using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI1.Controllers
{
    public class selecoes
    {
        public static List<selecoes> listaSelecoes = new List<selecoes>();
        public String nome;
        public bandeira endBandeira;
        public String continente;
        public int numeroTitulos;
        public jogadores jogadores;
        public String coresPrincipais;
        public String grupo;
        public String posicao;

        public selecoes()
        {

        }

        public selecoes(String nome, bandeira endBandeira, String continente, int numeroTitulos, jogadores jogadores, String coresPrincipais, String grupo, String posicao)
        {
            this.nome = nome;
            this.endBandeira = endBandeira;
            this.continente = continente;
            this.numeroTitulos = numeroTitulos;
            this.jogadores = jogadores;
            this.coresPrincipais = coresPrincipais;
            this.grupo = grupo;
            this.posicao = posicao;
            listaSelecoes.Add(this);
        }

        public List<selecoes> listarSelecoes(List<jogadores> lista_jogadores, List<bandeira> lista_Bandeira)
        {
            selecoes time1 = new selecoes("Equador", lista_Bandeira[0], "AmericaDoSul", 16, lista_jogadores[0], "Amarelo, azul e vermelho", "GrupoA", "2º");
            selecoes time2 = new selecoes("Holanda", lista_Bandeira[1], "Europa", 5, lista_jogadores[1], "Azul, Branco e Vermelho", "GrupoA", "1º");
            selecoes time3 = new selecoes("Qatar", lista_Bandeira[2], "Asia", 1, lista_jogadores[2], "Vermelho vinho", "GrupoA", "1º");
            selecoes time4 = new selecoes("Senegal", lista_Bandeira[3], "Africa", 15, lista_jogadores[3], "Amarelo, Verde e Vermelho", "GrupoA", "3º");
            selecoes time5 = new selecoes("Inglaterra", lista_Bandeira[4], "Europa", 7, lista_jogadores[4], "Branco e Vermelho", "GrupoB", "4º");
            selecoes time6 = new selecoes("Irão", lista_Bandeira[5], "Asia", 7, lista_jogadores[5], "Branco, Verde e Vermelho", "GrupoB", "2º");
            selecoes time7 = new selecoes("E.U.A ", lista_Bandeira[6], "AmericaDoNorte", 8, lista_jogadores[6], "Azul, Branco e Vermelho", "GrupoB", "3º");
            selecoes time8 = new selecoes("País da Gales", lista_Bandeira[7], "Europa", 12, lista_jogadores[7], "Branco, Verde e Vermelho", "GrupoB", "4º");
            selecoes time9 = new selecoes("Argentina", lista_Bandeira[8], "AmericaDoSul", 15, lista_jogadores[8], "Amarelo, Azul e Branco", "GrupoC", "4º");
            selecoes time10 = new selecoes("México", lista_Bandeira[9], "AmericaDoSul", 59, lista_jogadores[9], "Branco, Verde e Vermelho", "GrupoC", "3º");
            selecoes time11 = new selecoes("Polônia", lista_Bandeira[10], "Europa", 2, lista_jogadores[10], "Branco e Vermelho", "GrupoC", "4º");
            selecoes time12 = new selecoes("Arábia Saudita", lista_Bandeira[11], "Asia", 3, lista_jogadores[11], "Verde", "GrupoC", "2º");
            selecoes time13 = new selecoes("Austrália", lista_Bandeira[12], "Oceania", 2, lista_jogadores[12], "Azul, Branco e Vermelho", "GrupoD", "2º");
            selecoes time14 = new selecoes("Dinamarca", lista_Bandeira[13], "Europa", 7, lista_jogadores[13], "Branco e Vermelho", "GrupoD", "1º");
            selecoes time15 = new selecoes("França", lista_Bandeira[14], "Europa", 6, lista_jogadores[14], "Branco,, Azul e Vermelho", "GrupoD", "4º");
            selecoes time16 = new selecoes("Tunísia", lista_Bandeira[15], "Europa", 29, lista_jogadores[15], "Branco e Vermelho", "GrupoD", "4º");
            selecoes time17 = new selecoes("Costa Rica", lista_Bandeira[16], "AmericaCentral", 46, lista_jogadores[16], "Azul, Branco e Vermelho", "GrupoE", "2º");
            selecoes time18 = new selecoes("Alemanha", lista_Bandeira[17], "Europa", 4, lista_jogadores[17], "Preto, Amarelo e Vermelho", "GrupoE", "2º");
            selecoes time19 = new selecoes("Japão", lista_Bandeira[18], "Asia", 54, lista_jogadores[18], "Branco e Vermelho", "GrupoE", "4º");
            selecoes time20 = new selecoes("Espanha", lista_Bandeira[19], "Europa", 35, lista_jogadores[19], "Amarelo e Vermelho", "GrupoE", "1º");
            selecoes time21 = new selecoes("Bélgica", lista_Bandeira[20], "Europa", 3, lista_jogadores[20], "Preto, Amarelo e Vermelho", "GrupoF", "2º");
            selecoes time22 = new selecoes("Canadá", lista_Bandeira[21], "AmericaDoNorte", 2, lista_jogadores[21], "Branco e Vermelho", "GrupoF", "2º");
            selecoes time23 = new selecoes("Croácia", lista_Bandeira[22], "Europa", 6, lista_jogadores[22], "Azul, Branco e Vermelho", "GrupoF", "2º");
            selecoes time24 = new selecoes("Marrocos", lista_Bandeira[23], "Africa", 6, lista_jogadores[23], "Vermelho", "GrupoF", "3º");
            selecoes time25 = new selecoes("Brasil", lista_Bandeira[24], "AmericaDoSul", 5, lista_jogadores[24], "Verde, Amarelo e Azul", "GrupoG", "1º");
            selecoes time26 = new selecoes("Camarões", lista_Bandeira[25], "Africa", 5, lista_jogadores[25], "Amarelo, Verde e Vermelho", "GrupoG", "4º");
            selecoes time27 = new selecoes("Sérvia", lista_Bandeira[26], "Europa", 9, lista_jogadores[26], "Azul, Branco e Vermelho", "GrupoG", "2º");
            selecoes time28 = new selecoes("Suíça", lista_Bandeira[27], "Europa", 2, lista_jogadores[27], "Vermelho e Branco", "GrupoG", "3º");
            selecoes time29 = new selecoes("Gana", lista_Bandeira[28], "Africa", 5, lista_jogadores[28], "Verde, Amarelo e Vermelho", "GrupoH", "2º");
            selecoes time30 = new selecoes("Portugal", lista_Bandeira[29], "Europa", 20, lista_jogadores[29], "Verde e Vermelho", "GrupoH", "3º");
            selecoes time31 = new selecoes("República da Coreia", lista_Bandeira[30], "Asia", 8, lista_jogadores[30], "Branco, Azul e Vermelho", "GrupoH", "4º");
            selecoes time32 = new selecoes("Uruguai", lista_Bandeira[31], "AmericaDoSul", 19, lista_jogadores[31], "Azul, Branco e Amarelo", "GrupoH", "3º");

            listaSelecoes.Add(time1);
            listaSelecoes.Add(time2);
            listaSelecoes.Add(time3);
            listaSelecoes.Add(time4);
            listaSelecoes.Add(time5);
            listaSelecoes.Add(time6);
            listaSelecoes.Add(time7);
            listaSelecoes.Add(time8);
            listaSelecoes.Add(time9);
            listaSelecoes.Add(time10);
            listaSelecoes.Add(time11);
            listaSelecoes.Add(time12);
            listaSelecoes.Add(time13);
            listaSelecoes.Add(time14);
            listaSelecoes.Add(time15);
            listaSelecoes.Add(time16);
            listaSelecoes.Add(time17);
            listaSelecoes.Add(time18);
            listaSelecoes.Add(time19);
            listaSelecoes.Add(time20);
            listaSelecoes.Add(time21);
            listaSelecoes.Add(time22);
            listaSelecoes.Add(time23);
            listaSelecoes.Add(time24);
            listaSelecoes.Add(time25);
            listaSelecoes.Add(time26);
            listaSelecoes.Add(time27);
            listaSelecoes.Add(time28);
            listaSelecoes.Add(time29);
            listaSelecoes.Add(time30);
            listaSelecoes.Add(time31);
            listaSelecoes.Add(time32);

            return selecoes.listaSelecoes;
        }

        public List<jogadores> listarJogadores()
        {
            List<jogadores> listaJogadores = new List<jogadores>();
            // listaJogadores = listarJogadores(listaJogadores);

            jogadores time1j = new jogadores("Equador: Alexander Domínguez, Gonzalo Valle, Hernan Galindez, Wellington Ramírez, William Joel Pacho Tenorio, Piero Hincapié, Carlos Gruezo, Sebastián Méndez, José Cifuentes, Alan Franco, Gonzalo Plata, Moises Caicedo, Patrickson Delgado, Enner Valencia, Romario Ibarra, Ángel Mena, Michael Estrada, Djorkaeff Reasco, Anthony Valencia, Nilson Angulo, Jeremy Sarmiento.");
            jogadores time2j = new jogadores("Holanda: Remko Pasveer, Jasper Cillessen, Mark Flekken, Andries Noppert,Daley Blind, Stefan de Vrij, Virgil van Dijk, Nathan Aké, Denzel Dumfries, Matthijs de Ligt,Tyrell Malacia, Jurriën Timber, Devyne Rensch, Marten de Roon, Davy Klaassen, Frenkie de Jong, Ryan Gravenberch, Kenneth Taylor, Steven Berghuis, Wout Weghorst, Vincent Janssen, Steven Bergwijn, Cody Gakpo, Brian Brobbey");
            jogadores time3j = new jogadores("Qatar: Saad Al Sheeb, Yousof Hassan, Meshaal Barsham, Salah Zakaria, Ró-Ró, Abdelkarim Hassan, Boualem Khoukhi, Salem Al Hajri, Bassam Al Rawi, Tarek Salman, Musaab Khidir, Ahmed Suhail, Homam Ahmed, Mohamed Emad Ayash, Jassem Gaber, Abdulsallam, Ahmed Fadel Hasaba, Abdelaziz Hatim, Karim Boudiaf, Assim Madabo, Hazem Shehata, Ismail Mohamad, Ali Asad, Abdelrahman Fahmi Moustafa, Mohammed Waad, Yusuf Abdurisag, Moustafa Tarek, Naif Abdulraheem Al Hadhrami, Osamah Al Tairi, Mohammed Muntari, Almoez Ali, Akram Afif, Hasan Al Haydos, Ahmed Alaa, Khalid Muneer Ali");
            jogadores time4j = new jogadores("Senegal: Alfred Gomis, Mory Diaw, Timothy Dieng, Édouard Mendy, Abdou Diallo, Formose Mendy, Kalidou Koulibaly, Moussa Niakhate, Pape Abou Cissé, Fodé Ballo-Toure, Ismail Jakobs, Noah Fadiga, Mamadou Loum, Idrissa Gueye, Nampalys Mendy, Cheikhou Kouyaté, Pape Gueye, Iliman Ndiaye, Pathé Ciss, Pape Sarr, Moustapha Name, Sadio Mané, Ismaïla Sarr, Krépin Diatta, Boulaye Dia, Demba Seck, Nicolas Jackson, Bamba Dieng");
            jogadores time5j = new jogadores("Inglaterra: Nick Pope, Dean Henderson, Aaron Ramsdale, Kyle Walker, Kieran Trippier, Eric Dier, Conor Coady, Harry Maguire, John Stones,Luke Shaw, Reece James, Ben Chilwell, Marc Guehi, Jordan Henderson, Mason Mount, Declan Rice, Phil Foden, Bukayo Saka, Jude Bellingham, Harry Kane, Raheem Sterling, Ivan Toney, Tammy Abraham");
            jogadores time6j = new jogadores("Irã: Hossein Hosseini, Alireza Beiranvand, Amir Abedzadeh,Sayedpayam Niazmand, Shojae Khalilzadeh, Majid Hosseini,Sadegh Moharrami, Morteza Pouraliganji, Ramin Rezaeian, Milad Mohammad,i Hossein Kanani, Omid Norafkan, Abolfazl Jalali, Saleh Hardani Kherad, Omid Ebrahimi, Saeid Ezatolahi, Ali Gholizadeh, Ehsan Hajsafi, Vahid Amiri, Mehdi Torabi, Ahmad Nourollahi, Milad Sarlak Chiva, Alireza Jahanbakhsh, Sardar Azmoun, Karim Ansarifard, Mehdi Taremi, Saman Ghoddos");
            jogadores time7j = new jogadores("E.U.A: Sean Johnson, Ethan Horvath Matt Turner, Walker Zimmerman, DeAndre Yedlin, Erik Palmer-Brown, Aaron Long, Reggie Cannon, Sam Vines, Sergiño Dest, Joe Scally, Kellyn Acosta, Paul Arriola, Tyler Adams, Christian Pulisic, Luca de la Torre, Weston McKennie, Brenden Aaronson, Giovanni Reyna, Johnny, Mark McKenzie, Jordan Morris, Jesús Ferreira, Joshua Sargent, Ricardo Pepi,  Malik Tillman");
            jogadores time8j = new jogadores("País de Gales: Danny Ward,  Wayne Hennessey, Tom King, Ben Davies, Chris Gunter, Connor Roberts, Joe Rodon, Ethan Ampadu, Chris Mepham, Rhys Norrington-Davies, Ben Cabango, Neco Williams, Jonny Williams, Luke Harris, Jordan James, Joe Morrell, Sorba Thomas, Dylan Levitt, Rubin Colwill, Mark Harris, Daniel James, Matt Smith, Gareth Bale, Wes Burns, Kieffer Moore, Tyler Roberts, Rabbi Matondo, Brennan Johnsonpolo");
            jogadores time9j = new jogadores("Argentina: Franco Armani, Emiliano Martínez, Gerónimo Rulli, Cristian Romero, Nicolás Otamendi, Germán Pezzella, Nicolás Tagliafico, Nahuel Molina, Gonzalo Montiel, Lisandro Martínez, Facundo Medina, Nehuén Pérez, Marcos Acuña, Ángel Di María, Papu Gómez, Leandro Paredes, Rodrigo De Paul, Giovani Lo Celso, Guido Rodríguez, Alexis Mac Allister, Thiago Almada, Enzo Fernández, Joaquín Correa, Lionel Messi, Paulo Dybala, Ángel Correa, Lautaro Martínez, Julián Álvarez.");
            jogadores time10j = new jogadores("México: Alfredo Talavera, Rodolfo Cota, Guillermo Ochoa, Héctor Moreno, Néstor Araujo, Kevin Álvarez, César Montes, Jesús Angulo, Gerardo Arteaga, Johan Vásquez, Andrés Guardado, Luis Chávez, Jesús Gallardo, Érick Gutiérrez, Orbelín Pineda, Carlos Rodríguez, Edson Álvarez, Fernando Beltrán, Diego Lainez, Henry Martín, Érick Sánchez, Roberto Alvarado, Hirving Lozano, Alexis Vega, Uriel Antuna, Santiago Giménez");
            jogadores time11j = new jogadores("Polônia: Wojciech Szczesny, Lukasz Skorupski, Bartlomiej Dragowski, Radoslaw Majecki, Kamil Glik, Bartosz Bereszynski, Tomasz Kedziora, Pawel Dawidowicz, Mateusz Wieteska, Jan Bednarek, Robert Gumny, Jakub Kiwior,Grzegorz Krychowiak, Kamil Grosicki, Mateusz Klich, Piotr Zielinski, Przemyslaw Frankowski, Karol Linetty, Sebastian Szymanski, Szymon Zurkowski, Arkadiusz Reca, Jakub Piotrowski, Michal Skoras, Jakub Kaminski, Mateusz Legowski, Robert Lewandowski, Arkadiusz Milik, Karol Swiderski, Krzysztof Piatek, Nicola Zalewski");
            jogadores time12j = new jogadores("Arábia Saudita: Fawaz Al-Qarni, Mohammed Al-Owais, Mohammed Al-Rubaie, Yaseer Al-Shahrani, Abdullah Madu, Ali Hadi Albulayhi, Hassan Al Tambakti, Abdulelah Al-Amri, Sultan Al-Ghanam, Saud Abdulhamid, Ahmed Bamasud, Salman Al-Faraj, Salem Al-Dawsari, Nawaf Al Abid, Riyadh Sharahili, Sami Al-Naji, Mohamed Kanno, Nasser Al-Dosari, Hattan Bahebri, Ali Al-Hassan, Awad Haidar Amer Al Nashri, Fahad Al Muwallad, Haroune Camara, Feras Al Brikan, Asiri Haitham.");
            jogadores time13j = new jogadores("Austrália: Andrew Redmayne, Mitch Langerak, Mat Ryan, Idade, Aziz Behich, Thomas Deng, Harrison Delbridge, Fran Karacic, Nathaniel Atkinson, Joel King, Ryan Strain, Aaron Mooy, Jackson Irvine, Awer Mabil, Ajdin Hrustic, Riley McGree, Denis Genreau, Keanu Baccus, Conor Metcalfe, Tyrese Francois, Cameron Devlin, Martin Boyle, Mathew Leckie, Adam Taggart, Mitch Duke, Jamie Maclaren, Jason Cummings, Marco Tilio, Garang Kuol.");
            jogadores time14j = new jogadores("Dinamarca: Kasper Schmeichel, Frederik Ronnow, Oliver Christensen, Simon Kjaer, Andreas Christensen, Jens Stryger Larsen, Joachim Andersen, Rasmus Kristensen, Joakim Maehle, Victor Nelsson, Alexander Bah, Christian Eriksen, Thomas Delaney, Daniel Wass, Pierre-Emile Hojbjerg, Casper Nielsen, Phillip Biling, Mathias Jensen, Jesper Lindstrom, Mikkel Damsgaard, Anders Dreyer, Martin Braithwaite, Kasper Dolberg, Andreas Skov Olsen, Rasmus Höjlund");
            jogadores time15j = new jogadores("França: Steve Mandanda, Alphonse Areola, Alban Lafont, Raphaël Varane, Benjamin Pavard, Ferland Mendy, Dayot Upamecano, Jonathan Clauss, William Saliba, Benoit Badiashile, Adrien Truffert, Jordan Veretout, Matteo Guendouzi, Aurélien Tchouaméni, Youssouf Fofana, Eduardo Camavinga, Olivier Giroud, Antoine Griezmann, Christopher Nkunku, Ousmane Dembélé, Kylian Mbappé, Randal Kolo Muani");
            jogadores time16j = new jogadores("Tunísia: Aymen Dahmen, Mohamed Sedki Debchi, Bechir Ben Said, Mohamed Drager, Hamza Mathlouthi, Ali Maâloul, Dylan Bronn, Rami Kaib, Yann Valery, Bilel Ifa, Montassar Talbi, Ali Abdi, Omar Rekik, Naïm Sliti, Ferjani Sassi, Nader Ghandri, Saif-Eddine Khaoui, Ellyes Skhiri, Aissa Laidouni, Ghaliene Chaaleli, Mortadha Ben Ouanes,  Hannibal Mejbri, Anis Ben Slimane, Sayfallah Ltaief, Chaïm El Djebali, Wahbi Khazri, Youssef M'Sakni, Taha Yassine Khenissi, Seifeddin Jaziri, Issam Jebali");
            jogadores time17j = new jogadores("Costa Rica: Esteban Alvarado, Aaron Cruz, Patrick Sequeira, Carlos Martinez, Kendall Waston, Bryan Oviedo, Francisco Calvo, Óscar Duarte, Juan Vargas, Douglas López, Keysher Fuller, Orlando Galo, Carlos Mora, Gerson Torres, Celso Borges, Anthony Hernández, Johan Venegas, Daniel Chacón, Brandon Aguilera, Aarón Suárez, Álvaro Zamora, Bryan Ruiz, Joel Campbell, Anthony Contreras, Jewison Bennette, Roan Wilson");
            jogadores time18j = new jogadores("Alemanha: Manuel Neuer (Goleiro), Marc-André ter Stegen (Goleiro) e Kevin Trapp (Goleiro), Armel Bella Kotchap, Matthias Ginter, Robin Gosens, Thilo Kehrer, David Raum, Antonio Rudiger, Nico Schlotterbeck e Niklas Sule, Julian Brandt, Serge Gnabry, Leon Goretzka, Ilkay Gundogan, Kai Havertz, Jonas Hofmann, Joshua Kimmich, Thomas Muller, Jamal Musiala, Lukas Nmecha, Marco Reus, Leroy Sané e Timo Werner.");
            jogadores time19j = new jogadores("Japão: Eiji Kawashima, Daniel Schmidt, Kosei Tani, Hiroki Ito, Maya Yoshida, Yuto Nagatomo, Hiroki Sakai, Shogo Taniguchi, Yuta Nakayama, Takehiro Tomiyasu, Miki Yamane, Ayumu Seko, Wataru Endo, Gaku Shibasaki, Takumi Minamino, Genki Haraguchi, Daichi Kamada, Ao Tanaka, Takefusa Kubo, Hidemasa Morita, Kaoru Mitoma, Reo Hatate, Junya Ito, Ritsu Doan, Shuto Machino, Ayase Ueda, Kyogo Furuhashi, Yuki Soma, Daizen Maeda");
            jogadores time20j = new jogadores("Espanha: Robert Sánchez, David Raya, Unai Simón, César Azpilicueta, Jordi Alba, Eric García, Dani Carvajal, José Gayà, Diego Llorente, Pau Torres, Hugo Guillamón, Sergio Busquets, Koke, Pablo Sarabia, Marcos Llorente, Rodri, Carlos Soler, Pedri, Yeremi Pino, Gavi, Álvaro Morata, Marco Asensio, Borja Iglesias, Ferran Torres, Nico Williams");
            jogadores time21j = new jogadores("Bélgica: Simon Mignolet, Thibaut Courtois, Koen Casteels, Matz Sels, Toby Alderweireld, Jan Vertonghen, Dedryck Boyata, Thomas Meunier, Jason Denayer, Brandon Mechele, Timothy Castagne, Wout Faes, Arthur Theate, Zeno Debast, Leander Dendoncker, Kevin De Bruyne, Thorgan Hazard, Axel Witsel, Yannick Carrasco, Youri Tielemans, Hans Vanaken, Alexis Saelemaekers, Charles De Ketelaere, Amadou Onana, Dries Mertens, Eden Hazard, Michy Batshuayi, Leandro Trossard, Dodi Lukebakio, Loïs Openda.");
            jogadores time22j = new jogadores("Canadá: Milan Borjan, Maxime Crépeau, Dayne St. Clair, Steven Vitória, Sam Adekugbe, Richie Laryea,  Alphonso Davies, Joel Waterman, Derek Cornelius, Kamal Miller, Alistair Johnston Scott Kennedy, Samuel Piette, Jonathan Osorio, Mark-Anthony Kaye, Stephen Eustáquio, Ismael Koné, Luca Koleosho, Junior Hoilett, Lucas Cavallini, Cyle Larin, Ike Ugbo, Liam Millar, Jonathan David, Tajon Buchanan, Theo Corbeanu, Charles-Andreas Brym");
            jogadores time23j = new jogadores("Croácia: Lovre Kalinic, Dominik Livakovic, Ivica Ivusic, Dejan Lovren, Domagoj Vida, Martin Erlic, Borna Barisic, Josip Juranovic, Borna Sosa, Josip Stanisic, Josko Gvardiol, Josip Sutalo, Luka Modric,  Ivan Perisic, Mateo Kovacic, Marcelo Brozovic, Mario Pasalic, Nikola Vlasic, Lovro Majer, Luka Sucic, Andrej Kramaric, Marko Livaja, Bruno Petkovic, Mislav Orsic, Ante Budimir");
            jogadores time24j = new jogadores("Marrocos: Bono, Anass Zniti, Ahmed Tagnaouti, Munir, Romain Saïss, Fahd Moufi, Samy Mmaee, Jawad El Yamiq, Noussair Mazraoui, Achraf Hakimi, Badr Banoun, Achraf Dari, Yahia Attiyat Allah, Younès Belhanda, Hakim Ziyech, Sofyan Amrabat, Selim Amallah, Amine Harit,  Abdelhamid Sabiri, Ilias Chair, Yahya Jabrane, Azz-Eddine Ounahi, Sofiane Boufal, Munir El Haddadi, Ryan Mmaee, Youssef En-Nesyri, Ayoub El Kaabi, Soufiane Rahimi, Zakaria Aboukhlal, Walid Cheddira, Abde Ezzalzouli");
            jogadores time25j = new jogadores("Brasil:  Ederson, Alisson, Weverton, Thiago Silva, Marquinhos, Danilo, Alex Telles, Éder Militão, Bremer, Ibañez, Renan Lodi, Fred, Casemiro, Fabinho, Éverton Ribeiro, Bruno Guimarães, Lucas Paquetá, Neymar, Roberto Firmino, Richarlison, Raphinha, Pedro, Vinícius Júnior, Matheus Cunha, Rodrygo, Antony ");
            jogadores time26j = new jogadores("Camarões: André Onana, Devis Epassy, Simon Ngapandouetnbu, Christopher Wooh, Jean-Charles Castelletto, Nicolas N'Koulou, Oumar Gonzalez, Léandre Tawamba, Jean-Pierre Nsame, Vincent Aboubakar, Bryan Mbeumo, Georges-Kevin N'Koudou, Nicolas Moumi Ngamaleu, Karl Toko Ekambi, Pierre Kunde, Olivier Ntcham, Georges Mandjeck, Gaël Ondoua, Samuel Oum Gouet, Martin Hongla, Jean Onana, Enzo Tchato, Nouhou, Darlin Yongwa, Olivier Mbaizo, Collins Fai");
            jogadores time27j = new jogadores("Sérvia: Marko Dmitrovic, Vanja Milinkovic, Marko Ilic, Filip Mladenovic, Milos Veljkovic, Srdan Babic, Aleksa Terzic, Strahinja Erakovic, Strahinja Pavlovic, Darko Lazovic, Nemanja Gudelj, Filip Djuricic, Filip Kostic, Andrija Zivkovic, Sergej Milinkovic-Savic, Nemanja Radonjic, Nemanja Maksimovic, Sasa Lukic, Erhan Masovic, Uros Racic, Ivan Ilić, Dusan Tadic, Aleksandar Mitrovic, Luka Jovic, Dusan Vlahovic, Stefan Mitrovic");
            jogadores time28j = new jogadores("Suíça: Yann Sommer, Yvon Mvogo, Jonas Omlin, David Von Ballmoos12, Ricardo Rodríguez, Silvan Widmer, Kevin Mbabu, Fabian Schär, Nico Elvedi, Manuel Akanji, Eray Cömert, Fabian Frei, Xherdan Shaqiri, Granit Xhaka, Remo Freuler, Renato Steffen, Djibril Sow, Denis Zakaria, Michel Aebischer, Ruben Vargas, Ardon Jasari, Haris Seferovic, Breel Embolo, Cedric Itten, Dan Ndoye, Mohamed Zeki Amdouni");
            jogadores time29j = new jogadores("Gana: Richard Ofori, Joseph Wollacott, Abdul Manaf Nurudeen, Denis Odoi, Baba Rahman, Alexander Djiku, Daniel Amartey, Joseph Aidoo, Gideon Mensah, Stephen Ambrosius, Tariq Lamptey, Mohammed Salisu, Alidu Seidu, Thomas Partey, Elisha Owusu, Mohammed Kudus, Daniel-Kofi Kyereh, Iddrisu Baba, Kamaldeen Sulemana, Fatawu Issahaku, André Ayew, Jordan Ayew, Iñaki Williams, Benjamin Tetteh, Antoine Semenyo, Osman Bukari, Ransford-Yeboah Königsdörffer, Daniel Barnieh, Felix Afena-Gyan");
            jogadores time30j = new jogadores("Portugal: Rui Patrício, José Sá, Diogo Costa, Mário Rui, João Cancelo, Rúben Dias, Diogo Dalot, Tiago Djaló, Nuno Mendes, Danilo Pereira, Bruno Fernandes, William Carvalho, João Mário, Bernardo Silva, Rúben Neves, João Palhinha, Vitinha, Matheus Nunes, Cristiano Ronaldo, Ricardo Horta, Diogo Jota, Pedro Neto, Rafael Leão, João Félix, Gonçalo Ramos");
            jogadores time31j = new jogadores("República da Coreia: Kim Seung-Gyu, Kim Dong-Jun, Song Bum-Keun, Hong Chul, Kim Tae-Hwan, Kim Min-Jae, Kim Young-Gwon, Kim Jin-Su, Kwon Kyung-Won, Jonggy Yoon, Kim Moon-Hwan, Lee Jae-Sung, Jung Woo-Young, Kwon Chang-Hoon, Seung-Ho Paik, Son Jun-Ho, Lee Kang-In, Woo-Yeong Jeong, Hwang In-Beom, Na Sang-Ho, Yu-Min Cho, Hyun-Jun Yang, Son Heung-Min, Hwang Ui-Jo, Hwang Hee-Chan, Young-Wook Cho");
            jogadores time32j = new jogadores("Uruguai: Fernando Muslera, Sebastián Sosa, Sergio Rochet, Martín Cáceres, Damián Suárez, Leandro Cabrera, Gullermo Varela, Mathías Olivera, Matías Viña, Agustin Rogel,  Sebastián Cáceres, Matías Vecino, Giorgian de Arrascaeta, Lucas Torreira, Rodrigo Bentancur, Federico Valverde, Manuel Ugarte, Nicolás De La Cruz, Facundo Pellistri, Luis Suárez, Diego Rossi, Agustín Canobbio, Darwin Núñez, Brian Ocampo, Martín Satriano");

            listaJogadores.Add(time1j);
            listaJogadores.Add(time2j);
            listaJogadores.Add(time3j);
            listaJogadores.Add(time4j);
            listaJogadores.Add(time5j);
            listaJogadores.Add(time6j);
            listaJogadores.Add(time7j);
            listaJogadores.Add(time8j);
            listaJogadores.Add(time9j);
            listaJogadores.Add(time10j);
            listaJogadores.Add(time11j);
            listaJogadores.Add(time12j);
            listaJogadores.Add(time13j);
            listaJogadores.Add(time14j);
            listaJogadores.Add(time15j);
            listaJogadores.Add(time16j);
            listaJogadores.Add(time17j);
            listaJogadores.Add(time18j);
            listaJogadores.Add(time19j);
            listaJogadores.Add(time20j);
            listaJogadores.Add(time21j);
            listaJogadores.Add(time22j);
            listaJogadores.Add(time23j);
            listaJogadores.Add(time24j);
            listaJogadores.Add(time25j);
            listaJogadores.Add(time26j);
            listaJogadores.Add(time27j);
            listaJogadores.Add(time28j);
            listaJogadores.Add(time29j);
            listaJogadores.Add(time30j);
            listaJogadores.Add(time31j);
            listaJogadores.Add(time32j);

            /*for (int i = 0; i < listaJogadores.Count; i++)            
            {
                listaSelecoes[i].jogadores = listaJogadores[i].nome_Jogador;
            }
            */
            return listaJogadores;

        }
        public List<bandeira> listarBandeiras()
        {
            List<bandeira> listaBandeira = new List<bandeira>();
            //listaBandeira = listarBandeiras(listaBandeira);

            bandeira time1b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/ecu.png&h=200&w=200");
            bandeira time2b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/ned.png&h=200&w=200");
            bandeira time3b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/qat.png&h=200&w=200");
            bandeira time4b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/sen.png&h=200&w=200");
            bandeira time5b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/eng.png&h=200&w=200");
            bandeira time6b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/irn.png&h=200&w=200");
            bandeira time7b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/usa.png&h=200&w=200");
            bandeira time8b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/wal.png&h=200&w=200");
            bandeira time9b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/arg.png&h=200&w=200");
            bandeira time10b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/mex.png&h=200&w=200");
            bandeira time11b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/pol.png&h=200&w=200");
            bandeira time12b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/ksa.png&h=200&w=200");
            bandeira time13b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/aus.png&h=200&w=200");
            bandeira time14b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/den.png&h=200&w=200");
            bandeira time15b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/arg.png&h=200&w=200");
            bandeira time16b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/tun.png&h=200&w=200");
            bandeira time17b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/crc.png&h=200&w=200");
            bandeira time18b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/ger.png&h=200&w=200");
            bandeira time19b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/jpn.png&h=200&w=200");
            bandeira time20b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/tun.png&h=200&w=200");
            bandeira time21b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/bel.png&h=200&w=200");
            bandeira time22b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/can.png&h=200&w=200");
            bandeira time23b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/cro.png&h=200&w=200");
            bandeira time24b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/mar.png&h=200&w=200");
            bandeira time25b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/bra.png&h=200&w=200");
            bandeira time26b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/crm.png&h=200&w=200");
            bandeira time27b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/sba.png&h=200&w=200");
            bandeira time28b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/sui.png&h=200&w=200");
            bandeira time29b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/gha.png&h=200&w=200");
            bandeira time30b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/por.png&h=200&w=200");
            bandeira time31b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/kors.png&h=200&w=200");
            bandeira time32b = new bandeira("https://a.espncdn.com/combiner/i?img=/i/teamlogos/countries/500/uru.png&h=200&w=200");

            listaBandeira.Add(time1b);
            listaBandeira.Add(time2b);
            listaBandeira.Add(time3b);
            listaBandeira.Add(time4b);
            listaBandeira.Add(time5b);
            listaBandeira.Add(time6b);
            listaBandeira.Add(time7b);
            listaBandeira.Add(time8b);
            listaBandeira.Add(time9b);
            listaBandeira.Add(time10b);
            listaBandeira.Add(time11b);
            listaBandeira.Add(time12b);
            listaBandeira.Add(time13b);
            listaBandeira.Add(time14b);
            listaBandeira.Add(time15b);
            listaBandeira.Add(time16b);
            listaBandeira.Add(time17b);
            listaBandeira.Add(time18b);
            listaBandeira.Add(time19b);
            listaBandeira.Add(time20b);
            listaBandeira.Add(time21b);
            listaBandeira.Add(time22b);
            listaBandeira.Add(time23b);
            listaBandeira.Add(time24b);
            listaBandeira.Add(time25b);
            listaBandeira.Add(time26b);
            listaBandeira.Add(time27b);
            listaBandeira.Add(time28b);
            listaBandeira.Add(time29b);
            listaBandeira.Add(time30b);
            listaBandeira.Add(time31b);
            listaBandeira.Add(time32b);

            return listaBandeira;

        }

    }
}
