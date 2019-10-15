using BlogMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace BlogMvc.Tests
{
    public class PostControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new PostController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
