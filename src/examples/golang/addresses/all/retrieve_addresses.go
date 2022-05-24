package main

import (
	"encoding/json"
	"fmt"
	"os"

	"github.com/EasyPost/easypost-go/v2"
)

func main() {
	apiKey := os.Getenv("EASYPOST_TEST_API_KEY")

	client := easypost.New(apiKey)

	// Retrieve a list of addresses
	address, err := client.ListAddresses(
		&easypost.ListOptions{
			// options here
		},
	)
	if err != nil {
		fmt.Fprintln(os.Stderr, "error retrieving addresses:", err)
		os.Exit(1)
	}

	prettyJSON, err := json.MarshalIndent(address, "", "    ")
	if err != nil {
		fmt.Fprintln(os.Stderr, "error creating JSON:", err)
	}
	fmt.Printf("%s\n", string(prettyJSON))
}
