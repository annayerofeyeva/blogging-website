using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    [Table("Posts")]
    public class Post
    {
        public int postId { get; set;  }
        public string postAuthor { get; set; }
        public DateTime postAddedAt { get; set; }
        public string postContent { get; set; }

        public void AddPost(Post post)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PostContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPost", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramAuthor = new SqlParameter();
                paramAuthor.ParameterName = "@postAuthor";
                paramAuthor.Value = post.postAuthor;
                cmd.Parameters.Add(paramAuthor);

                SqlParameter paramAddedAt = new SqlParameter();
                paramAddedAt.ParameterName = "@postAddedAt";
                paramAddedAt.Value = post.postAddedAt;
                cmd.Parameters.Add(paramAddedAt);

                SqlParameter paramContent = new SqlParameter();
                paramContent.ParameterName = "@postContent";
                paramContent.Value = post.postContent;
                cmd.Parameters.Add(paramContent);

                con.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void EditPost(Post post)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PostContext"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spEdit", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@postId";
                paramId.Value = post.postId;
                cmd.Parameters.Add(paramId);

                SqlParameter paramContent = new SqlParameter();
                paramContent.ParameterName = "@postContent";
                paramContent.Value = post.postContent;
                cmd.Parameters.Add(paramContent);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }


}