﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.Storage;
//.StorageClient;
using Microsoft.WindowsAzure;

namespace Azure
{
    //public class AzureDao
    //{
    //    private string accountName, accountKey;
    //    Uri blobEndpoint, queueEndpoint, tableEndpoint;

    //    public AzureDao(string accountName, string accountKey)
    //    {
    //        this.accountName = accountName;
    //        this.accountKey = accountKey;
    //        blobEndpoint = new Uri(String.Format("http://{0}.blob.core.windows.net/", accountName));
    //        queueEndpoint = new Uri(String.Format("http://{0}.queue.core.windows.net/", accountName));
    //        tableEndpoint = new Uri(String.Format("http://{0}.table.core.windows.net/", accountName));
    //    }

    //    public void DownloadFile(String containerName, String fileName, String key)
    //    {
    //        StorageCredentials credentials = new StorageCredentialsAccountAndKey(accountName, accountKey);

    //        CloudStorageAccount storageAccountInfo = new CloudStorageAccount(credentials, blobEndpoint, queueEndpoint, tableEndpoint);

    //        CloudBlobClient cloudBlobClient = storageAccountInfo.CreateCloudBlobClient();
    //        cloudBlobClient.Timeout = new TimeSpan(0, 30, 0);

    //        cloudBlobClient.GetContainerReference(containerName).CreateIfNotExist();
    //        CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

    //        cloudBlobContainer.GetBlobReference(key).DownloadToFile(fileName);
    //    }

    //    public void DeleteBlob(String containerName, String key)
    //    {
    //        StorageCredentials credentials = new StorageCredentialsAccountAndKey(accountName, accountKey);

    //        CloudStorageAccount storageAccountInfo = new CloudStorageAccount(credentials, blobEndpoint, queueEndpoint, tableEndpoint);

    //        CloudBlobClient cloudBlobClient = storageAccountInfo.CreateCloudBlobClient();
    //        cloudBlobClient.Timeout = new TimeSpan(0, 30, 0);

    //        cloudBlobClient.GetContainerReference(containerName).CreateIfNotExist();
    //        CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

    //        cloudBlobContainer.GetBlobReference(key).Delete();
    //    }

    //    public IEnumerable<Uri> ListFiles(String containerName)
    //    {
    //        List<Uri> ret = new List<Uri>();

    //        StorageCredentials credentials = new StorageCredentialsAccountAndKey(accountName, accountKey);

    //        CloudStorageAccount storageAccountInfo = new CloudStorageAccount(credentials, blobEndpoint, queueEndpoint, tableEndpoint);

    //        CloudBlobClient cloudBlobClient = storageAccountInfo.CreateCloudBlobClient();
    //        cloudBlobClient.Timeout = new TimeSpan(0, 30, 0);

    //        IEnumerable<IListBlobItem> blobs = cloudBlobClient.GetContainerReference(containerName).ListBlobs();
    //        foreach (IListBlobItem blob in blobs)
    //        {
    //            ret.Add(blob.Uri);
    //        }

    //        return ret;
    //    }
    //}
}
