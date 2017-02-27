﻿using AVP.Models.Entities;
using AVP.WebApi.Controllers;
using AVP.WebApi.Tests.TestData;
using AVP.WebApi.Tests.TestServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AVP.WebApi.Tests.ControllerTests
{
    public class UserPushLocationTest
    {
        private TestDAO _dao = new TestDAO();
        private TestAuthService _authService = new TestAuthService();

        [Fact]
        public async Task GetUserPushLocation()
        {
            //Arrange
            var controller = new UserPushLocationController(_dao, _authService);

            //Act
            var result = await controller.Get();

            //Assert
            var viewResult = Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public async Task GetUserAddressById()
        {
            //Arrange
            var controller = new UserPushLocationController(_dao, _authService);

            //Act
            var result = await controller.Get(1);

            //Assert
            var viewResult = Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public async Task UpdateUserAddress()
        {
            UserPushLocation emailLoc = new UserPushLocation()
            {
                UserPushLocationID = 1,
                UserID = 1,
                UserAddressID = 1,
                PhoneNumber = 9165551234
            };
            //Arrange
            var controller = new UserPushLocationController(_dao, _authService);

            //Act failure
            var result = await controller.Post(emailLoc);

            //Assert failure
            var failureResult = Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public async Task InsertUserAddress()
        {
            UserPushLocation emailLoc = new UserPushLocation()
            {
                UserPushLocationID = 1,
                UserID = 1,
                UserAddressID = 1,
                PhoneNumber = 9165555555
            };
            //Arrange
            var controller = new UserPushLocationController(_dao, _authService);

            //Act success
            var result = await controller.Put(emailLoc);

            //Assert success
            var failureResult = Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public async Task DeleteUserAddress()
        {
            UserPushLocation emailLoc = new UserPushLocation()
            {
                UserPushLocationID = 1,
                UserID = 1,
                UserAddressID = 1,
                PhoneNumber = 91655555555
            };
            //Arrange
            var controller = new UserPushLocationController(_dao, _authService);

            //Act failure
            var result = await controller.Delete(emailLoc);

            //Assert failure
            var failureResult = Assert.IsType<JsonResult>(result);
        }
    }
}
