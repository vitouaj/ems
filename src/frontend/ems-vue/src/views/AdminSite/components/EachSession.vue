<template>
    <v-row>
        <v-col cols="12" class="d-flex justify-center pb-0">
            <span class="text-caption" style="color:#FF7F00">session 1</span>
        </v-col>
        <v-col cols="12" class="py-0">
            <label for="eventName" class="labelText">Title</label><br />
            <text-field
                placeholder="e.g name of session"
            ></text-field>
        </v-col>
        <v-col cols="6" class="py-0">
            <label for="eventName" class="labelText">Date</label><br />
            <text-field
                placeholder="Date of session"
            ></text-field>
        </v-col>
        <v-col cols="6" class="py-0">
            <label for="StartDate" class="labelText">Start Time</label><br />
            <text-field
                placeholder="HH/MM/SS"
            ></text-field>
        </v-col>
        <v-col cols="6"></v-col>
        <v-col cols="6" class="py-0">
            <label for="EndDate" class="labelText">End Time</label><br />
            <text-field
                placeholder="HH/MM/SS"
            ></text-field>
        </v-col>
        <v-col cols="12" class="py-0">
            <label for="EndDate" class="labelText">Description</label><br />
            <v-textarea
                variant="solo"
                row-height="20"
                rows="2"
                auto-grow
                placeholder="type your description here..."
            ></v-textarea>
        </v-col>
    </v-row>
</template>

<script>
import TextField from './TextField.vue';

export default {
    components: {
        TextField,
      }
}
</script>

<style>
.labelText{
    color: #004B8D;
}
</style>