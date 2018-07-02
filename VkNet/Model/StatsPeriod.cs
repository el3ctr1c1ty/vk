﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VkNet.Model
{
	/// <summary>
	/// Статистика сообщества или приложения.
	/// </summary>
	[Serializable]
	public class StatsPeriod
	{
		/// <summary>
		/// Период начала отсчёта в формате YYYY-MM-DD.
		/// </summary>
		[JsonProperty("period_from")]
		[JsonConverter(typeof(IsoDateTimeConverter))]
		public DateTime PeriodFrom { get; set; }

		/// <summary>
		/// Период окончания отсчёта в формате YYYY-MM-DD.
		/// </summary>
		[JsonProperty("period_to")]
		[JsonConverter(typeof(IsoDateTimeConverter))]
		public DateTime PeriodTo { get; set; }

		/// <summary>
		/// Данные о посетителях и просмотрах.
		/// </summary>
		[JsonProperty("visitors")]
		public VisitorStats Visitors { get; set; }

		/// <summary>
		/// Данные об охвате.
		/// </summary>
		[JsonProperty("reach")]
		public ReachStats Reach { get; set; }

		/// <summary>
		/// Activity
		/// </summary>
		[JsonProperty("activity")]
		public Activity Activity { get; set; }
	}
}