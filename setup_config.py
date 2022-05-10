import os
import argparse


def main():
    parser = argparse.ArgumentParser(
        prog="setup_config",
        description="Setup the config file for the project",
        epilog="Commonly used for set the appcenter application secret")
    parser.add_argument("-s", "--secret", help="The secret to set")
    args = parser.parse_args()
    app_secret = os.environ.get('APPCENTER_SECRET', '')
    if args.secret:
        app_secret = args.secret
    if app_secret == '':
        print("No secret found, please set the APPCENTER_SECRET environment variable,"
        " or pass the secret as an argument")

    file_name = "Notes-Desktop/AppConfig.cs"
    lines = []
    with open(file_name, "r") as file:
        for line in file:
            line = line.replace('<%APPCENTER_SECRET%>', app_secret)
            lines.append(line)
    with open(file_name, "w") as file:
        file.write(''.join(lines))


if __name__ == "__main__":
    main()
