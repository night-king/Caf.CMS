﻿using CAF.Infrastructure.Core;
using CAF.Infrastructure.Core.Plugins;
using CAF.WebSite.Application.WebUI.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace CAF.WebSite.Application.WebUI.Mvc
{
	public class ProviderModel : ModelBase, ILocalizedModel<ProviderLocalizedModel>
	{
		private IList<ProviderLocalizedModel> _locales;
		
		[LangResourceDisplayName("Common.SystemName")]
		public string SystemName { get; set; }

		[LangResourceDisplayName("Common.FriendlyName")]
		[AllowHtml]
		public string FriendlyName { get; set; }

		[LangResourceDisplayName("Common.Description")]
		[AllowHtml]
		public string Description { get; set; }

		[LangResourceDisplayName("Common.DisplayOrder")]
		public int DisplayOrder { get; set; }

		public bool IsEditable { get; set; }

		public bool IsConfigurable { get; set; }

		public RouteInfo ConfigurationRoute { get; set; }

		public PluginDescriptor PluginDescriptor { get; set; }

		[LangResourceDisplayName("Admin.Providers.ProvidingPlugin")]
		public string ProvidingPluginFriendlyName { get; set; }

		/// <summary>
		/// Returns the absolute path of the provider's icon url. 
		/// </summary>
		/// <remarks>
		/// The parent plugin's icon url is returned as a fallback, if provider icon cannot be resolved.
		/// </remarks>
		public string IconUrl { get; set; }

		public IList<ProviderLocalizedModel> Locales
		{
			get
			{
				if (_locales == null)
				{
					_locales = new List<ProviderLocalizedModel>();
				}
				return _locales;
			}
			set
			{
				_locales = value;
			}
		}
	}

	public class ProviderLocalizedModel : ILocalizedModelLocal
	{
		public int LanguageId { get; set; }

		[LangResourceDisplayName("Common.FriendlyName")]
		[AllowHtml]
		public string FriendlyName { get; set; }

		[LangResourceDisplayName("Common.Description")]
		[AllowHtml]
		public string Description { get; set; }
	}

}