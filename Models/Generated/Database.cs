




















// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `DoAnChuyenNganhConnection`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=DESKTOP-OUUJBVE\SQLEXPRESS;Initial Catalog=doanachuyennganh;Integrated Security=True`
//     Schema:                 ``
//     Include Views:          `False`



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace DoAnChuyenNganhConnection
{

	public partial class DoAnChuyenNganhConnectionDB : Database
	{
		public DoAnChuyenNganhConnectionDB() 
			: base("DoAnChuyenNganhConnection")
		{
			CommonConstruct();
		}

		public DoAnChuyenNganhConnectionDB(string connectionStringName) 
			: base(connectionStringName)
		{
			CommonConstruct();
		}
		
		partial void CommonConstruct();
		
		public interface IFactory
		{
			DoAnChuyenNganhConnectionDB GetInstance();
		}
		
		public static IFactory Factory { get; set; }
        public static DoAnChuyenNganhConnectionDB GetInstance()
        {
			if (_instance!=null)
				return _instance;
				
			if (Factory!=null)
				return Factory.GetInstance();
			else
				return new DoAnChuyenNganhConnectionDB();
        }

		[ThreadStatic] static DoAnChuyenNganhConnectionDB _instance;
		
		public override void OnBeginTransaction()
		{
			if (_instance==null)
				_instance=this;
		}
		
		public override void OnEndTransaction()
		{
			if (_instance==this)
				_instance=null;
		}
        

		public class Record<T> where T:new()
		{
			public static DoAnChuyenNganhConnectionDB repo { get { return DoAnChuyenNganhConnectionDB.GetInstance(); } }
			public bool IsNew() { return repo.IsNew(this); }
			public object Insert() { return repo.Insert(this); }

			public void Save() { repo.Save(this); }
			public int Update() { return repo.Update(this); }

			public int Update(IEnumerable<string> columns) { return repo.Update(this, columns); }
			public static int Update(string sql, params object[] args) { return repo.Update<T>(sql, args); }
			public static int Update(Sql sql) { return repo.Update<T>(sql); }
			public int Delete() { return repo.Delete(this); }
			public static int Delete(string sql, params object[] args) { return repo.Delete<T>(sql, args); }
			public static int Delete(Sql sql) { return repo.Delete<T>(sql); }
			public static int Delete(object primaryKey) { return repo.Delete<T>(primaryKey); }
			public static bool Exists(object primaryKey) { return repo.Exists<T>(primaryKey); }
			public static bool Exists(string sql, params object[] args) { return repo.Exists<T>(sql, args); }
			public static T SingleOrDefault(object primaryKey) { return repo.SingleOrDefault<T>(primaryKey); }
			public static T SingleOrDefault(string sql, params object[] args) { return repo.SingleOrDefault<T>(sql, args); }
			public static T SingleOrDefault(Sql sql) { return repo.SingleOrDefault<T>(sql); }
			public static T FirstOrDefault(string sql, params object[] args) { return repo.FirstOrDefault<T>(sql, args); }
			public static T FirstOrDefault(Sql sql) { return repo.FirstOrDefault<T>(sql); }
			public static T Single(object primaryKey) { return repo.Single<T>(primaryKey); }
			public static T Single(string sql, params object[] args) { return repo.Single<T>(sql, args); }
			public static T Single(Sql sql) { return repo.Single<T>(sql); }
			public static T First(string sql, params object[] args) { return repo.First<T>(sql, args); }
			public static T First(Sql sql) { return repo.First<T>(sql); }
			public static List<T> Fetch(string sql, params object[] args) { return repo.Fetch<T>(sql, args); }
			public static List<T> Fetch(Sql sql) { return repo.Fetch<T>(sql); }
			public static List<T> Fetch(long page, long itemsPerPage, string sql, params object[] args) { return repo.Fetch<T>(page, itemsPerPage, sql, args); }
			public static List<T> Fetch(long page, long itemsPerPage, Sql sql) { return repo.Fetch<T>(page, itemsPerPage, sql); }
			public static List<T> SkipTake(long skip, long take, string sql, params object[] args) { return repo.SkipTake<T>(skip, take, sql, args); }
			public static List<T> SkipTake(long skip, long take, Sql sql) { return repo.SkipTake<T>(skip, take, sql); }
			public static Page<T> Page(long page, long itemsPerPage, string sql, params object[] args) { return repo.Page<T>(page, itemsPerPage, sql, args); }
			public static Page<T> Page(long page, long itemsPerPage, Sql sql) { return repo.Page<T>(page, itemsPerPage, sql); }
			public static IEnumerable<T> Query(string sql, params object[] args) { return repo.Query<T>(sql, args); }
			public static IEnumerable<T> Query(Sql sql) { return repo.Query<T>(sql); }

		}

	}
	



    

	[TableName("dbo.__MigrationHistory")]



	[PrimaryKey("MigrationId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class __MigrationHistory : DoAnChuyenNganhConnectionDB.Record<__MigrationHistory>  
    {



		[Column] public string MigrationId { get; set; }





		[Column] public string ContextKey { get; set; }





		[Column] public byte[] Model { get; set; }





		[Column] public string ProductVersion { get; set; }



	}

    

	[TableName("dbo.AspNetRoles")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetRole : DoAnChuyenNganhConnectionDB.Record<AspNetRole>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Name { get; set; }



	}

    

	[TableName("dbo.AspNetUserClaims")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class AspNetUserClaim : DoAnChuyenNganhConnectionDB.Record<AspNetUserClaim>  
    {



		[Column] public int Id { get; set; }





		[Column] public string UserId { get; set; }





		[Column] public string ClaimType { get; set; }





		[Column] public string ClaimValue { get; set; }



	}

    

	[TableName("dbo.AspNetUserLogins")]



	[PrimaryKey("LoginProvider", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserLogin : DoAnChuyenNganhConnectionDB.Record<AspNetUserLogin>  
    {



		[Column] public string LoginProvider { get; set; }





		[Column] public string ProviderKey { get; set; }





		[Column] public string UserId { get; set; }



	}

    

	[TableName("dbo.AspNetUserRoles")]



	[PrimaryKey("UserId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUserRole : DoAnChuyenNganhConnectionDB.Record<AspNetUserRole>  
    {



		[Column] public string UserId { get; set; }





		[Column] public string RoleId { get; set; }



	}

    

	[TableName("dbo.AspNetUsers")]



	[PrimaryKey("Id", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class AspNetUser : DoAnChuyenNganhConnectionDB.Record<AspNetUser>  
    {



		[Column] public string Id { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string Email { get; set; }





		[Column] public bool EmailConfirmed { get; set; }





		[Column] public string PasswordHash { get; set; }





		[Column] public string SecurityStamp { get; set; }





		[Column] public string PhoneNumber { get; set; }





		[Column] public bool PhoneNumberConfirmed { get; set; }





		[Column] public bool TwoFactorEnabled { get; set; }





		[Column] public DateTime? LockoutEndDateUtc { get; set; }





		[Column] public bool LockoutEnabled { get; set; }





		[Column] public int AccessFailedCount { get; set; }





		[Column] public string UserName { get; set; }



	}

    

	[TableName("dbo.Comments")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class Comment : DoAnChuyenNganhConnectionDB.Record<Comment>  
    {



		[Column] public int Id { get; set; }





		[Column] public string IdAccount { get; set; }





		[Column] public string NameAccount { get; set; }





		[Column] public string Content { get; set; }





		[Column] public DateTime Day { get; set; }





		[Column] public int ProductId { get; set; }





		[Column] public int Note { get; set; }



	}

    

	[TableName("dbo.Employees")]



	[PrimaryKey("EmployeeId")]




	[ExplicitColumns]

    public partial class Employee : DoAnChuyenNganhConnectionDB.Record<Employee>  
    {



		[Column] public int EmployeeId { get; set; }





		[Column] public string LastName { get; set; }





		[Column] public string FirstName { get; set; }





		[Column] public int BirthDate { get; set; }





		[Column] public string Address { get; set; }



	}

    

	[TableName("dbo.OrderDetails")]



	[PrimaryKey("OrderId", AutoIncrement=false)]


	[ExplicitColumns]

    public partial class OrderDetail : DoAnChuyenNganhConnectionDB.Record<OrderDetail>  
    {



		[Column] public int OrderId { get; set; }





		[Column] public int ProductId { get; set; }





		[Column] public double Price { get; set; }





		[Column] public int Quantity { get; set; }





		[Column] public double TotalPrice { get; set; }



	}

    

	[TableName("dbo.Orders")]



	[PrimaryKey("OrderId")]




	[ExplicitColumns]

    public partial class Order : DoAnChuyenNganhConnectionDB.Record<Order>  
    {



		[Column] public int OrderId { get; set; }





		[Column] public string CustomerId { get; set; }





		[Column] public DateTime OrderDate { get; set; }





		[Column] public int EmployeesId { get; set; }





		[Column] public bool Confirmed { get; set; }





		[Column] public bool Delivered { get; set; }



	}

    

	[TableName("dbo.Producers")]



	[PrimaryKey("IdProducer")]




	[ExplicitColumns]

    public partial class Producer : DoAnChuyenNganhConnectionDB.Record<Producer>  
    {



		[Column] public int IdProducer { get; set; }





		[Column] public string NameProducer { get; set; }





		[Column] public string Status { get; set; }



	}

    

	[TableName("dbo.Products")]



	[PrimaryKey("Id")]




	[ExplicitColumns]

    public partial class Product : DoAnChuyenNganhConnectionDB.Record<Product>  
    {



		[Column] public int Id { get; set; }





		[Column] public string Name { get; set; }





		[Column] public string Description { get; set; }





		[Column] public int PublicYear { get; set; }





		[Column] public int Price { get; set; }





		[Column] public string Cover { get; set; }





		[Column] public string Cover1 { get; set; }





		[Column] public string Cover2 { get; set; }





		[Column] public string Cover3 { get; set; }





		[Column] public string Cover4 { get; set; }





		[Column] public int Quantity { get; set; }





		[Column] public string Like { get; set; }





		[Column] public int IdProductType { get; set; }





		[Column] public int IdProducer { get; set; }





		[Column] public string Note { get; set; }



	}

    

	[TableName("dbo.ProductTypes")]



	[PrimaryKey("IdProductType")]




	[ExplicitColumns]

    public partial class ProductType : DoAnChuyenNganhConnectionDB.Record<ProductType>  
    {



		[Column] public int IdProductType { get; set; }





		[Column] public string NameType { get; set; }





		[Column] public string Status { get; set; }



	}


}
