<template>
    <v-text-field
        :placeholder="placeholder"
        :variant="variant"
        :density="density"
    ></v-text-field>
</template>

<script>
    export default {
        props: {
            placeholder : String,
            variant: {
                type: String,
                default: 'solo'
            },
            density: {
                type: String,
                default: "compact"
            }
        }
    }
</script>