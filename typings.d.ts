//module to import json into TypeScript
declare module "*.json" {
	const value: any;
	export default value;
}

