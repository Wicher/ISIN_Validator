﻿using System;
using System.IO;
using FluentAssertions;
using ISIN_Validator.Configuration.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISIN_Validator_Tests.Configuration_Tests
{
    [TestClass]
    public class ConfigurationFileReaderTests
    {
        private const string SampleFileContents = "Test";
        private const string TestFilename = "Test_File.json";

        private ConfigurationFileReader _configurationFileReader;
        private string _testFileFullPath;

        [TestInitialize]
        public void TestInit()
        {
            _configurationFileReader = new ConfigurationFileReader();
            _testFileFullPath = Path.Combine(Environment.CurrentDirectory, TestFilename);
            File.WriteAllText(_testFileFullPath, SampleFileContents);
        }

        [TestCleanup]
        public void TestClean()
        {
            _configurationFileReader = null;
            if(File.Exists(_testFileFullPath))
                File.Delete(_testFileFullPath);
        }

        [TestMethod]
        public void FileReaderFailsWhenFileIsNotAvailable()
        {
            const string dummyFilename = "dummyFile.txt";

            Action act = () => _configurationFileReader.ReadConfigurationFile(dummyFilename);

            act.Should().Throw<Exception>()
                .WithMessage("Configuration file does not exist");
        }

        [TestMethod]
        public void FileReaderReadsFileContentsWhenFileIsAvailable()
        {
            const string expectedValue = SampleFileContents;

            string actualValue = _configurationFileReader.ReadConfigurationFile(_testFileFullPath);

            actualValue.Should().Be(expectedValue);
        }
    }
}