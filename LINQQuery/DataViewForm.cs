using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LinqQuery
{
    public partial class DataViewForm : Form
    {
        const string FILTER = @"ALL FILES(*.*)|*.*|XML FILES(*.xml)|*.xml";
        XmlSerializer cdSerializer = new XmlSerializer(typeof(List<CD>));
        XmlSerializer producerSerializer = new XmlSerializer(typeof(List<PRODUCER>));
        List<CD> cdList;
        List<PRODUCER> producerList;
        BindingSource source = new BindingSource();
        public DataViewForm()
        {
            InitializeComponent();
            cdList = new List<CD>();
            producerList = new List<PRODUCER>();
        }


        /// <summary>
        /// Opening file and creating on his basement object <ArrayOfCd> arrOfCd </ArrayOfCd>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = FILTER;
            dlg.InitialDirectory = Environment.CurrentDirectory;


            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(Environment.CurrentDirectory);
                if (dlg.FileName == files[0])
                {
                    using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                    {
                        cdList = cdSerializer.Deserialize(fs) as List<CD>;
                    }

                    CDGrid.DataSource = cdList;
                }

                else
                {
                    using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                    {
                        producerList = producerSerializer.Deserialize(fs) as List<PRODUCER>;
                    }
                    producersGrid.DataSource = producerList;

                }
            }
                
        }
        /// <summary>
        /// Query that show all artists, that out they albums after 1991 year.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listOfAllArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var artists = (from cd in cdList where cd.YEAR >= 1991 select new { Artist = cd.ARTIST }).ToList();
            queryGrid.DataSource = artists;
        }
        /// <summary>
        /// Shows all countries without repeat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var countries = cdList.Select(cd => new { Country = cd.COUNTRY }).Distinct().ToList();
            queryGrid.DataSource = countries;
        }
        /// <summary>
        /// Show albums that was out in USA (sorted by years).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showListOfAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var albums = cdList.Where(cd => cd.COUNTRY == "USA").OrderBy(cd => cd.YEAR).Select(cd => new { Album = cd.TITLE }).ToList();
            queryGrid.DataSource = albums;
        }
        /// <summary>
        /// Show total cost of all albums in countries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTotalCostOfAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var totalCost = (from cd in cdList group cd by cd.COUNTRY into gr select new { Total_value = gr.Sum(cd => cd.PRICE), Country = gr.Key }).ToList();
            queryGrid.DataSource = totalCost;
        }
        /// <summary>
        /// Show count of albums of every label(company)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showListOfCompaniesAndCountOfAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infoAboutLabel = cdList.OrderBy(cd => cd.YEAR).GroupBy(cd => cd.COMPANY).Select(gr => new { Company = gr.Key, Albums = gr.Count() }).ToList();
            queryGrid.DataSource = infoAboutLabel;
        }
        /// <summary>
        /// Show albums of the most talanted producer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTheMostTalantedProducerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var maxValue = producerList.Where(prod => prod.FEE == producerList.Max(p => p.FEE)).FirstOrDefault();
            var prodInfo = (from prod in producerList
                            join cd in cdList on prod.ID equals cd.PRODUCER
                            where prod.FEE == maxValue.FEE
                            select new { Name = prod.NAME, Albums = cd.TITLE }).ToList();
            queryGrid.DataSource = prodInfo;

        }
        /// <summary>
        /// Show count of albums of every producer in period from 1988 to 1990.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showCountOfSongsInPeriodOf1988To1990ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var producersAndAlbums = (from cd in cdList
                                      group cd by new { cd.PRODUCER, cd.YEAR } into gr
                                      join prod in producerList on gr.Key.PRODUCER equals prod.ID
                                      where gr.Key.YEAR >= 1988 && gr.Key.YEAR <= 1990
                                      select new { Producer = prod.NAME, Albums = gr.Count() }).ToList();
            queryGrid.DataSource = producersAndAlbums;
        }
        /// <summary>
        /// Show producer that get his revard last
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void producerThatGetBonusLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var producer = producerList.Where(p => p.DATE == producerList.Min(pr => pr.DATE)).Select(p => new { Producer = p.NAME }).ToList();
            queryGrid.DataSource = producer;
        }
        /// <summary>
        /// Show the cheapest album and also shows name of Artist and producer of this album.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTheCheapestAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infoAboutAlbum = cdList.Join(producerList, cd => cd.PRODUCER, p => p.ID, (cd, p) => new { Song = cd.TITLE, Artist = cd.ARTIST, Producer = p.NAME, Price = cd.PRICE }).
                Where(album => album.Price == cdList.Min(cd => cd.PRICE)).Select(info => new { Album = info.Song, Artist = info.Artist, Producer = info.Producer }).ToList();
            queryGrid.DataSource = infoAboutAlbum;
        }
        /// <summary>
        /// Show sorted information about all albums
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showSortedInfoAboutAllAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedInfoAboutAlbums = from a in cdList orderby a.YEAR, a.PRICE, a.TITLE select a;
            queryGrid.DataSource = sortedInfoAboutAlbums.ToList();
        }
    }
}