﻿namespace FluentMigrator.Tests
{
	public static class IntegrationTestOptions
	{
		public static DatabaseServerOptions SqlServer = new DatabaseServerOptions
															{
																ConnectionString =
																	@"server=(local);uid=;pwd=;Trusted_Connection=yes;database=FluentMigrator",
																IsEnabled = true
															};

		public static DatabaseServerOptions SqlLite = new DatabaseServerOptions
															{
																ConnectionString =
																	@"Data Source=:memory:;Version=3;New=True;",
																IsEnabled = false
															};

		public static DatabaseServerOptions MySql = new DatabaseServerOptions
														{
															ConnectionString =
																@"Database=FluentMigrator;Data Source=localhost;User Id=test;Password=test;",
															IsEnabled = false
														};

		public class DatabaseServerOptions
		{
			public string ConnectionString;
			public bool IsEnabled = true;
		}
	}
}