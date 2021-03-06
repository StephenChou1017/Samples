// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using WPAppStudio.Entities;
using WPAppStudio.Repositories.Base;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// TheNextOneSchema data source.
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    [System.CodeDom.Compiler.GeneratedCode("Radarc", "4.0")]
    public class TheNextOneCollection : ITheNextOneCollection 
    {
		private readonly IJsonDataSource _jsonDataSource; 

		private const string DataServiceUrl = "http://dowapp.cloudapp.net/api/data?clientId={0}&appId={1}&datasourceName={2}";

        /// <summary>
        /// Initializes a new instance of the <see cref="TheNextOneCollection" /> class.
        /// </summary>
        /// <param name="jsonDataSource">A JSON based data source.</param>
        public TheNextOneCollection(IJsonDataSource jsonDataSource)
        {
            _jsonDataSource = jsonDataSource;
        }
		
        /// <summary>
        /// Retrieves the data from a dynamic data service (URL specified in DataServiceUrl) , in an observable collection of TheNextOneSchema items.
        /// </summary>
        /// <returns>An observable collection of TheNextOneSchema items.</returns>
        public async Task<ObservableCollection<TheNextOneSchema>> GetData()
        {			
            return await LoadData();
        } 
		 
        private async Task<ObservableCollection<TheNextOneSchema>> LoadData()
        {
            var items = await _jsonDataSource.LoadRemote<TheNextOneSchema[]>(string.Format(DataServiceUrl, "18484","ac2d4de4-fb44-4f54-9847-2adca862706b", "TheNextOneCollection"));
            return items != null ? new ObservableCollection<TheNextOneSchema>(items.OrderBy(i=>i.Title)) : new ObservableCollection<TheNextOneSchema>();
        }
	}	
}
