using BlogMvc.Controllers;
using BlogMvc.Models;
using BlogMvc.Repository;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace BlogMvc.Tests
{
    public class PostControllerTests
    {
        
            PostController underTest;
            IRepository<PostModel> postrepo;
            PostModel posttest;
            
            public PostControllerTests()
            {
                posttest = new PostModel(21, "Post Name", "Body", "Img", "Author", 1, 1);
                postrepo = Substitute.For<IRepository<PostModel>>();
                underTest = new PostController(postrepo);

            }

            [Fact]
            public void PostConstructor_Sets_Title_On_Model()
            {
                var result = posttest.Title;

                Assert.Equal("Post Name", result);
            }

            [Fact]
            public void PostConstructor_Sets_ID()
            {
                var result = posttest.ID;

                Assert.Equal(21, result);

            }

            [Fact]
            public void PostConstructor_Sets_Body()
            {
                var result = posttest.Body;

                Assert.Equal("Content", result);
            }

            [Fact]
            public void PostConstructor_Sets_Image()
            {
                var result = posttest.Image;

                Assert.Equal("Img", result);
            }

            [Fact]
            public void Details_Passes_To_View()
            {
                var result = underTest.Details(1);
                Assert.IsType<ViewResult>(result);
            }
            [Fact]
            public void Details_Passes_Single_Post()
            {
                var expectedHero = new PostModel();
                postrepo.GetByID(1).Returns(expectedHero);
                var result = underTest.Details(1);
                Assert.Equal(expectedHero, result.Model);
            }
            [Fact]
            public void Index_Returns_A_View()
            {
                var result = underTest.Index();
                Assert.IsType<ViewResult>(result);
            }
            
        }
    }

