using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BlueSkyTravel.Models;

namespace BlueSkyTravel.Tests
{
    public class VoteModelTests
    {
        Vote myVote = new Vote();

        public VoteModelTests()
        {
            myVote = new Vote(1, true);
        }

        [Fact]
        public void VoteConstructor_Sets_Id_On_Model()
        {
            var result = myVote.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void VoteConstructor_Sets_voteChoice_On_Model()
        {
            var result = myVote.VoteChoice;

            Assert.True(result);
        }



    }
}
