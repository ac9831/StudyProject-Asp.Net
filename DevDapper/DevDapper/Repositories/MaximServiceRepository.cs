using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using DevDapper.Models;

namespace DevDapper.Repositories
{
    public class MaximServiceRepository
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        // 입력
        public Maxim AddMaxim(Maxim model)
        {
            string sql = @"Insert Into Maxims (Name, Content) Values (@Name, @Content); 
                           Select Cast(SCOPE_IDENTITY() As Int);";
            var id = this.db.Query<int>(sql, model).Single();
            model.Id = id;
            return model;
        }

        // 출력
        public List<Maxim> GetMaxims()
        {
            string sql = "Select Id, name, Content, CreationDate From Maxims Order By Id Asc";
            return this.db.Query<Maxim>(sql).ToList();
        }

        // 상세
        public Maxim GetMaximById(int id)
        {
            string sql = "Select Id, name, Content, CreationDate From Maxims Where Id = @Id";
            return this.db.Query<Maxim>(sql, new { Id = id }).SingleOrDefault();
        }

        // 수정
        public Maxim UpdateMaxim(Maxim model)
        {
            string sql = "Update Maxims Set Name = @Name, Content = @Content Where ID = @Id";
            this.db.Execute(sql, model);
            return model;
        }


        // 삭제
        public void RemoveMaxim(int id)
        {
            string sql = "Delete Maxims Where Id = @Id";
            this.db.Execute(sql, new { Id = id });
        }
    }
}