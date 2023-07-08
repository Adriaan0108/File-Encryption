# Background
Encryption or cryptography is the science of obscuring/ modifying information in order to hide the contents thereof to anyone who is not supposed to see it. Encryption has been around in some form or another for a very long time. The use thereof can be linked to early variations of the Egyptian, Roman and Greek militaries. The earliest form of encryption was the substitution cipher. This encryption method entails swopping letters or groups of letters with other letters or groups of letters. The key would be used by the person encrypting and person decrypting in order to determine the substitutions and therefore the hidden message. Encryption took a great leap forward during World War 2 when the Enigma machine was invented by Arthur Scherbius. The Enigma machine was used by the Germans to send secret messages that could not be interpreted by the enemy. The invention of the world wide web was responsible for making encryption more mainstream. More and more sensitive data were being moved into computer storage and the need for the protection of that data grew exponentially. Modern encryption methods use RSA (public- and private key) to encrypt information. Encryption plays a very big part in the world in the 21st century. Secure websites use encryption in order to ensure that web traffic is secure. Emails and instant messaging services such as WhatsApp rely on encryption in order to provide secure communication services. Due to the sensitive nature of information kept at banks and financial institutions, encryption plays an essential role in almost all operations. As has been the case throughout history, encryption plays an increasingly important role in militaries around the world. With the deployment of more and more computerized systems such as armed drones, cyber security has become a top priority. The strongest encryption that is available today is AES (Advanced Encryption Standard) 256. 

# Code explained
![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/d94543d1-fcbe-479a-a4d7-f241566a27d5)
The main screen provides the user the option to either encrypt or decrypt a file. When encrypting a file, the user clicks on the “Browse” button. They are then able to browse their documents to find the file they wish to encrypt. After filling in their own password, they can click on the “Save encrypted file” button. The file explorer opens again and they are presented with the option to choose the name and save location of the encrypted file. The original file is then deleted from the user’s file explorer.
Decrypting a file follows a similar format to encrypting a file. The user first selects the file they wish to decrypt under the “Browse” button. The password is then entered. If the password is correct the user can click on the “Save decrypted file” button. The file explorer will open and the user will be able to choose where and under what name they want to save the decrypted file. Once the decrypted file is saved, the encrypted file is deleted.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/38542cd0-343b-425e-b3a3-e518cfa99886)
<br>using System.IO for creating and deleting files. 
using System.Security.Cryptography for encoding and decoding data.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/ea6b8106-8b80-4a2c-9194-402b70bfb328)
Declaring and initialising global variables for the files that will be encrypted and decrypted respectively.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/8f93b623-b2b9-4672-9c98-a956adfa2aa1)
The AES_Encrypt() method is declared (the parameters are the bytes to be encrypted array and the password bytes array). Firstly, an empty array of salt bytes is declared. Followed by this is the assigning of values to that salt array. The data that will be accessed by the memory stream is then encapsulated. Rfc2898DeriveBytes is used to implement password-based key derivation functionality. The Key size and block size are set to 256 and 128, respectively. key.GetBytes is used to get the size of the secret key. key.GetBytes is then used to get the initialization vector from the block size. AES.Mode = CipherMode.CBC sets the block cipher mode to Cipher Block Chaining CBC). The bytes are then written to the CryptoStream. 


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/30fc04dc-8922-42fd-bb7a-8687b66cd370)
The AES_Decrypt() method is declared (the parameters are the bytes to be decrypted array and the password bytes array). Firstly, an empty array of salt bytes is declared. Followed by this is the assigning of values to that salt array. The data that will be accessed by the memory stream is then encapsulated. Rfc2898DeriveBytes is used to implement password-based key derivation functionality. The Key size and block size are set to 256 and 128 respectively. key.GetBytes is used to get the size of the secret key. key.GetBytes is then used to get the initialization vector from the block size. AES.Mode = CipherMode.CBC sets the block cipher mode to Cipher Block Chaining (CBC). The bytes are then written to the CryptoStream.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/dc3aabd1-eb16-4d08-bba0-52b2a5b1ede4)
The doNotEncrypt variable is declared to ensure that encryption will only take place under the right circumstances (a file is selected and a password filled in). File.Exists is used in order to ensure that the file to be encrypted is still located at the location where it was selected under “Browse”. String.IsNullOrEmpty is used in order to ensure that the password that the user entered in the textbox is not empty. If both of these conditions are met, the EncryptFile() method is executed.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/92c59f28-7621-4bf5-a726-a33025dda43a)
The noFileSelected variable is declared to ensure that decryption will only take place under the right circumstances (a file is selected and the correct password is provided). The DecryptFile() method is executed. If decryption does not take place, the exception ex executes. Either no file is selected or the password is incorrect. The corresponding message is displayed to the user.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/7641ff6f-4826-4686-ab24-d40fc3ffd5b5)
The EncryptFile() method is declared. An empty password string is declared and then initialized to the password that the user provided in the textbox. The content of the file is read into the bytes to be encrypted array. The characters are then encoded using the password. SHA256 is used in order to hash the password. The AES_Encrypt() method is called and given the bytesToBeEncrypted and the passwordBytes as parameters. Path.GetExtention is used in order to get the extension of the file as this will be added to the encrypted file again. A save file dialog box appears to give the user the option to choose the name and save location of the encrypted file. The encrypted file is then saved to the desired location using File.WriteAllBytes. 


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/8760e8f8-18b8-4698-a37a-b09cf4fbe473)
The DecryptFile() method is declared. An empty password string is declared and then initialized to the password that the user provided in the textbox. The content of the file is read into the bytes to be decrypted array. The characters are then decoded using the password. SHA256 is used in order to compute the hash password. The AES_Decrypt method is called and given the bytesToBeDecrypted and the passwordBytes as parameters. Path.GetExtention is used in order to get the extension of the file as this will be added to the decrypted file again. A save file dialog box appears to give the user the option to choose the name and save location of the decrypted file. The decrypted file is then saved to the desired location using File.WriteAllBytes. 



![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/f25181d0-55b6-42f0-a1d2-4926ca7b4eec)
Opening a file dialog box for the user to select the file to be encrypted. The file path of the file is obtained in order to be used when the encrypted file is saved.


![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/6d587106-01ea-4bb3-b7d3-3d78cc639689)
Opening a file dialog box for the user to select the file to be decrypted. The file path of the file is obtained in order to be used when the decrypted file is saved.

 
 # What Rijndael encryption is 
Rijndael encryption was invented by Joan Daemen and Vincent Rijmen. Rijndael is classified as an AES (Advanced Encryption Standard) algorithm. Rijndael supports key sizes of 128- (9 matrix transformations), 192- (11 matrix transformations), and 256- (13 matrix transformations) bits and handles data in 128-bit blocks. A matrix transformation contains the following four steps:
1.	Sub Bytes: Each byte contained in the block is replaced by a substitution byte.
2.	Shift Rows: Bytes are contained in a block and are shifted using block sizes as a reference.
3.	Mix Columns: Each column is multiplied by the matrix using matrix multiplication.
4.	Add Round Key: A subkey is combined with the state. A different sub-key is used for each matrix transformation.
During the early 2000’s the then-defector standard encryption algorithm, DES (Data Encryption Standard), had started showing some deficiencies, especially in terms of brute force attacks. NIST (the National Institute of Standards and Technology) evaluated several encryption algorithms in order to replace DES and Rijndael as AES was ultimately selected). 
DES uses 56-bit keys while Rijndael uses 128-bit keys. This means 1 021 times more AES 128-bit keys than DES 56-bit keys. The more times Rijndael is performed with different keys, the more challenging the encryption becomes to break. With my encryption program I set the key size to 256 for maximum security 
![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/23cfc060-8cc2-4f87-89e3-763c999b8e68)

## Advantages of Rijndael encryption:
Block sizes can mirror those of their particular keys. Rijndael is also relatively simple to implement and see the effects of. Rijndael can be performed faster than DES by a factor of 3. Rijndael is able to use a varying number of keys during encryption, providing greater flexibility. Rijndael implements alternating mix columns and mix row transformations to enhance its security and circumvent cyber-attacks. Rijndael is associated with low memory requirements, meaning that it can be implemented with high efficiency and performance.
![image](https://github.com/IvanPotgieter01/File-Encryption/assets/109952133/95ddeaff-4879-4f4b-bb1f-5c00d2c31736)
## Disadvantages of Rijndael encryption:
Rijndael encryption may be susceptible to a certain type of cyber-attack called a square attack. A square attack is based on the method of matrix multiplication.

# Conclusion
In conclusion, encryption is playing an ever-increasingly important role in the world we live in. It is no longer only used by militaries and governments but is now widely used by most citizens of the world in one form or another. Encryption is the best currently known method of keeping data (especially digital data) secure. There are several different encryption algorithms. I chose Rijndael AES encryption for my file encryption program as it is very secure and relatively simple to implement. Rijndael also provides several benefits over other encryption algorithms such as DES. Keys of different sizes can be used with Rijndael encryption. I used 256-bit keys in my program as this provides maximum security.
